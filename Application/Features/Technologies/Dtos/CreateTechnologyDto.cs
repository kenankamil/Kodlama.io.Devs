﻿namespace Application.Features.Technologies.Dtos
{
    public class CreateTechnologyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgrammingLanguageId { get; set; }
    }
}
