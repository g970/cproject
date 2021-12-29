def git_Url;
def msbuildHome;
def scannerHome;
def sonar_url;
def sonar_project_token;
node {
    stage('checkout') 
       {
        // Check out the C sharp code from a GitHub repository by using below pipeline syntax command
         git_Url = "https://github.com/mohankrishna1990/C-Sharp-Examples.git"
         //git_Url = "https://github.com/malcomvetter/WidgetSender.git"
         
         //Below command is used to check Git URL
         checkout([$class: 'GitSCM',branches: [[name: '*/master']], extensions: [],userRemoteConfigs: [[credentialsId: 'Git_repo_ID', url: "${git_Url}"]]])
         }
    stage('static_code_analysis') 
        {
        msbuildHome = tool 'MSbuild_Home'
        scannerHome = tool 'SonarScanner_MSBuild'
        sonar_url = "http://localhost:9000"
        sonar_project_token = "7d1a54173391c7f5b05a7a169732c4beae609c9e"
            
            withSonarQubeEnv() 
            {
            //Below command is used to begin the sonar scanner for our porject(jenkins_pipeline_scripted is the name of the token from sonar)   
            bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" begin /k:jenkins_pipeline_scripted /d:sonar.host.url=${sonar_url} /d:sonar.login=${sonar_project_token}"
            //Below command is used to generate the nuget package for rebbuild
            bat "\"${msbuildHome}\\MSBuild.exe\" -t:restore"
            //Below command is used to build the application
            bat "\"${msbuildHome}\\MSBuild.exe\" /t:Rebuild"
            //Below command is used to end the sonar scanner which we have begin in first step
            bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" end /d:sonar.login=${sonar_project_token}"
            }
        }
    }
