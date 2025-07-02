using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Delete{{cookiecutter.project_slug}};

public sealed class Delete{{cookiecutter.project_slug}}CommandValidator : AbstractValidator<Delete{{cookiecutter.project_slug}}Command>
{
    public Delete{{cookiecutter.project_slug}}CommandValidator()
    {
    }
}
