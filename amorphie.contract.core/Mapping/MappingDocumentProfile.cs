using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amorphie.contract.core.Entity.Document;
using AutoMapper;

namespace amorphie.contract.core.Mapping
{
    public class MappingDocumentProfile : Profile
    {
        public MappingDocumentProfile()
        {
            CreateMap<Document, Document>().ReverseMap();
            CreateMap<DocumentAllowed, DocumentAllowed>().ReverseMap();
            CreateMap<DocumentAllowedDetail, DocumentAllowedDetail>().ReverseMap();
            CreateMap<DocumentAllowedType, DocumentAllowedType>().ReverseMap();
            CreateMap<DocumentContent, DocumentContent>().ReverseMap();
            CreateMap<DocumentDefinition, DocumentDefinition>().ReverseMap();
            CreateMap<DocumentDefinitionLanguageDetail, DocumentDefinitionLanguageDetail>().ReverseMap();
            CreateMap<DocumentEntityProperty, DocumentEntityProperty>().ReverseMap();
            CreateMap<DocumentFormat, DocumentFormat>().ReverseMap();
            CreateMap<DocumentFormatDetail, DocumentFormatDetail>().ReverseMap();
            CreateMap<DocumentFormIO, DocumentFormIO>().ReverseMap();
            CreateMap<DocumentDefinitionGroup, DocumentDefinitionGroup>().ReverseMap();
            CreateMap<DocumentDefinitionGroupDetail, DocumentDefinitionGroupDetail>().ReverseMap();
            CreateMap<DocumentDefinitionGroupLanguageDetail, DocumentDefinitionGroupLanguageDetail>().ReverseMap();
            CreateMap<DocumentOptimize, DocumentOptimize>().ReverseMap();
            CreateMap<DocumentSize, DocumentSize>().ReverseMap();
            CreateMap<DocumentTag, DocumentTag>().ReverseMap();
            CreateMap<DocumentTemplate, DocumentTemplate>().ReverseMap();
            CreateMap<DocumentTemplateDetail, DocumentTemplateDetail>().ReverseMap();
            CreateMap<DocumentType, DocumentType>().ReverseMap();
            CreateMap<DocumentVersions, DocumentVersions>().ReverseMap();

        }
    }
}