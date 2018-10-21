We could not find a data exchange file at the path System.Configuration.ConfigurationErrorsException: L'Ã©lÃ©ment <unitTestProvider> ne peut apparaÃ®tre qu'une seule fois dans cette section.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
System.Configuration.ConfigurationErrorsException: L'Ã©lÃ©ment <unitTestProvider> ne peut apparaÃ®tre qu'une seule fois dans cette section.
   Ã  System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
   Ã  System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
   Ã  TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
   Ã  TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
   Ã  TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
   Ã  TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   Ã  TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   Ã  TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: C:\Users\Admin\AppData\Local\Microsoft\VisualStudio\14.0\Extensions\hcsptsq0.dvo\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\Admin\AppData\Local\Temp\tmpB99C.tmp --outputdirectory C:\Users\Admin\AppData\Local\Temp --projectsettingsfile C:\Users\Admin\AppData\Local\Temp\tmpB98B.tmp
Working Directory: c:\Users\Admin\Documents\Visual Studio 2015\Projects\azeddini.BDD.MeetingRoom\packages\SpecFlow.2.4.0\tools