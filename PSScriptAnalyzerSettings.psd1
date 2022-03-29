# PSScriptAnalyzerSettings.psd1
# Settings for PSScriptAnalyzer invocation.
@{
    #IncludeRules = @{}

    ExcludeRules = @(
        "PSAvoidGlobalVars",
        "PSUseSingularNouns"
    )

    Severity = @(
        "Warning",
        "Error",
        "Information"
    )
}
