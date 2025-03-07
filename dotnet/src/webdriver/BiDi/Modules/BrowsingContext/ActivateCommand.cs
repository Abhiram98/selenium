using OpenQA.Selenium.BiDi.Communication;

#nullable enable

namespace OpenQA.Selenium.BiDi.Modules.BrowsingContext;

internal class ActivateCommand(ActivateCommandParameters @params) : Command<ActivateCommandParameters>(@params);

internal record ActivateCommandParameters(BrowsingContext Context) : CommandParameters;

public record ActivateOptions : CommandOptions;
