
using amorphie.core.Module.minimal_api;
using amorphie.contract.data.Contexts;
using FluentValidation;
using amorphie.core.Base;

namespace amorphie.contract;

/*
    public abstract class BaseBBTRoute<TDTOModel, TDBModel, TValidator, ProjectDbContext>
        : BaseBBTRouteRepository<TDTOModel, TDBModel, TValidator, ProjectDbContext, IBBTRepository<TDBModel, ProjectDbContext>>
        where TDTOModel : class, new()
        where TDBModel : EntityBase
        where TValidator : AbstractValidator<TDBModel>
    {
        protected BaseBBTRoute(WebApplication app) : base(app)
        {
        }

        public override string[]? PropertyCheckList => throw new NotImplementedException();

        public override string? UrlFragment => throw new NotImplementedException();

    }

*/