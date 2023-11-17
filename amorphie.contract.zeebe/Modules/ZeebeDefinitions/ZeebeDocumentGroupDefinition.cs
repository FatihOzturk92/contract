using amorphie.contract.data.Contexts;
using amorphie.contract.zeebe.Model;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using amorphie.contract.zeebe.Services.Interfaces;

namespace amorphie.contract.zeebe.Modules.ZeebeDocumentDef
{
    public static class ZeebeDocumentGroupDefinition
    {
        public static void MapZeebeDocumentDefinitionEndpoints(this WebApplication app)
        {
            app.MapPost("/documentgroupdefinition", documentgroupdefinition)
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi(operation =>
            {
                operation.Summary = "Maps Render service worker on Zeebe";
                operation.Tags = new List<OpenApiTag> { new() { Name = "Zeebe" } };
                return operation;
            });

            app.MapPost("/errordocumentgroupdefinition", errordocumentgroupdefinition)
          .Produces(StatusCodes.Status200OK)
          .WithOpenApi(operation =>
          {
              operation.Summary = "Maps Render service worker on Zeebe";
              operation.Tags = new List<OpenApiTag> { new() { Name = "Zeebe" } };
              return operation;
          });
            app.MapPost("/deletedocumentgroupdefinition", deletedocumentgroupdefinition)
          .Produces(StatusCodes.Status200OK)
          .WithOpenApi(operation =>
          {
              operation.Summary = "Maps Render service worker on Zeebe";
              operation.Tags = new List<OpenApiTag> { new() { Name = "Zeebe" } };
              return operation;
          });
            app.MapPost("/timeoutdocumentgroupdefinition", timeoutdocumentgroupdefinition)
          .Produces(StatusCodes.Status200OK)
          .WithOpenApi(operation =>
          {
              operation.Summary = "Maps Render service worker on Zeebe";
              operation.Tags = new List<OpenApiTag> { new() { Name = "Zeebe" } };
              return operation;
          });

        }
        static IResult documentgroupdefinition(
          [FromBody] dynamic body,
         [FromServices] ProjectDbContext dbContext,
          HttpRequest request,
          HttpContext httpContext,
          [FromServices] DaprClient client
          , IConfiguration configuration,
           [FromServices] IDocumentDefinitionService IDocumentDefinitionService
      )
        {
            var messageVariables = new MessageVariables();
            try
            {
                messageVariables = ZeebeMessageHelper.VariablesControl(body);

            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

            try
            {

                dynamic? entityData = messageVariables.Data.GetProperty("entityData").ToString();

                var _ = IDocumentDefinitionService.DataModelToDocumentDefinition(entityData, messageVariables.RecordIdGuid);

                messageVariables.Success = true;
                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }

            catch (Exception ex)
            {
                messageVariables.Success = true;
                messageVariables.Message = ex.Message;
                messageVariables.LastTransition = "ErrorDefinition";

                return Results.BadRequest(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }
        }

        static IResult timeoutdocumentgroupdefinition(
        [FromBody] dynamic body,
        [FromServices] ProjectDbContext dbContext,
        HttpRequest request,
        HttpContext httpContext,
        [FromServices] DaprClient client
        , IConfiguration configuration
        )
        {
            var messageVariables = new MessageVariables();
            try
            {
                messageVariables = ZeebeMessageHelper.VariablesControl(body);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

            try
            {
                // dynamic? entityData = messageVariables.Data.GetProperty("entityData");
                // string reference = entityData.GetProperty("reference").ToString();
                // string deviceId = entityData.GetProperty("deviceId").ToString();
                messageVariables.Success = true;
                messageVariables.LastTransition = "TimeoutDefinitionUpload";
                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }

            catch (Exception ex)
            {
                messageVariables.Success = true;
                messageVariables.Message = ex.Message;
                messageVariables.LastTransition = "ErrorDefinitionUpload";

                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }
        }
        static IResult deletedocumentgroupdefinition(
        [FromBody] dynamic body,
        [FromServices] ProjectDbContext dbContext,
        HttpRequest request,
        HttpContext httpContext,
        [FromServices] DaprClient client
        , IConfiguration configuration
        )
        {
            var messageVariables = new MessageVariables();
            try
            {
                messageVariables = ZeebeMessageHelper.VariablesControl(body);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

            try
            {
                // dynamic? entityData = messageVariables.Data.GetProperty("entityData");
                // string reference = entityData.GetProperty("reference").ToString();
                // string deviceId = entityData.GetProperty("deviceId").ToString();
                messageVariables.Success = true;
                messageVariables.LastTransition = "DeleteProcessDefinitionUpload";
                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }

            catch (Exception ex)
            {
                messageVariables.Success = true;
                messageVariables.Message = ex.Message;
                messageVariables.LastTransition = "ErrorDefinitionUpload";

                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }
        }
        static IResult errordocumentgroupdefinition(
        [FromBody] dynamic body,
        [FromServices] ProjectDbContext dbContext,
        HttpRequest request,
        HttpContext httpContext,
        [FromServices] DaprClient client
        , IConfiguration configuration
        )
        {
            var messageVariables = new MessageVariables();
            try
            {
                messageVariables = ZeebeMessageHelper.VariablesControl(body);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

            try
            {
                // dynamic? entityData = messageVariables.Data.GetProperty("entityData");
                // string reference = entityData.GetProperty("reference").ToString();
                // string deviceId = entityData.GetProperty("deviceId").ToString();
                messageVariables.Success = true;
                messageVariables.LastTransition = "ErrorDefinitionUpload";
                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }

            catch (Exception ex)
            {
                messageVariables.Success = true;
                messageVariables.Message = ex.Message;
                messageVariables.LastTransition = "ErrorDefinitionUpload";

                return Results.Ok(ZeebeMessageHelper.CreateMessageVariables(messageVariables));
            }
        }
    }



}