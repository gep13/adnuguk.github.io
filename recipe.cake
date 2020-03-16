#load nuget:https://www.nuget.org/api/v2?package=Cake.Wyam.Recipe&version=0.8.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "Aberdeen Developers .Net User Group",
                            repositoryOwner: "adnuguk",
                            repositoryName: "adnuguk.github.io",
                            appVeyorAccountName: "adnuguk",
                            webHost: "aberdeendevelopers.co.uk",
                            shouldPurgeCloudflareCache: true);

BuildParameters.PrintParameters(Context);

Build.Run();
