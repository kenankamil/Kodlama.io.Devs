﻿using Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguage;
using Application.Features.Technologies.Dtos;
using Application.Features.Technologies.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Queries.GetListTechnology
{
    public class GetListTechnologyQuery : IRequest<TechnologyListModel>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListTechnologyQueryHandler : IRequestHandler<GetListTechnologyQuery, TechnologyListModel>
        {
            private readonly IMapper _mapper;
            private readonly ITechnologyRepository _technologyRepository;

            public GetListTechnologyQueryHandler(IMapper mapper, ITechnologyRepository technologyRepository)
            {
                _mapper = mapper;
                _technologyRepository = technologyRepository;
            }

            public async Task<TechnologyListModel> Handle(GetListTechnologyQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Technology> result = await _technologyRepository.GetListAsync(include:
                                                                                        t => t.Include(c => c.ProgrammingLanguage),
                                                                                        index: request.PageRequest.Page,
                                                                                        size: request.PageRequest.PageSize);
                var mappedModel = _mapper.Map<TechnologyListModel>(result);

                return mappedModel;
            }
        }
    }
}
