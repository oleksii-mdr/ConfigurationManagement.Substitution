	<!--This section is updated by the AfterBuild MSBuild task-->

	<!--Depending on the configuration the content of Web.config is fully 
	    substituted by the correspondent file from the 'Config' directory-->

	<!--This is a sample task, that needs to be inserted into the .proj file -->
	<!--Copy correct config file over to the output directory-->
	<Target Name="AfterBuild">
		<Delete Files="$(ProjectDir)Web.config" />
		<Copy SourceFiles="$(ProjectDir)\Config\Web.$(Configuration).config" DestinationFiles="$(ProjectDir)Web.config" />
	</Target>
