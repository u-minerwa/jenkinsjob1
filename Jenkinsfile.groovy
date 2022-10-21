pipeline {
    agent any

    stages {
        stage('build') {
            steps {
                bat "build.bat"
            }
        }
        stage('test') {
            steps {
                bat "buildTest.bat"
            }
        }
	    
	    stage('Archive'){
                steps{
			dir('C:\\'){
				echo "Current build: ${BUILD_NUMBER}"
				zip zipFile: "${BUILD_NUMBER}.zip", archive:false, dir: 'Users\\Alex\\AppData\\Local\\Jenkins\\.jenkins\\workspace\\TestJankins\\Calc\\bin\\Debug\\netcoreapp3.1'
				archiveArtifacts artifacts: "${BUILD_NUMBER}.zip"
			}
		  }
    	}
	    stage('Deploy'){
		  steps{
			  dir('C:\\'){
				  script{
					  try
					  {
						  bat("md C:\\Deploy\\")
					  }catch(Exception e){}
				  }
				  unzip zipFile: "${BUILD_NUMBER}.zip", dir: 'C:\\Deploy'
			  }
		  }
	  }
  }
	    post {
        always{
           emailext attachLog: true, body: '''$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS:
            Check console output at $BUILD_URL to view the results.''', subject: '$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS!',
                to: 'kocherginalekseysstu@gmail.com'
            }
        }
    }

