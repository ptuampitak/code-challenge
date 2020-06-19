# Code-challenge
Automation script for calling Wiremock API
This automation test script implemented by .NET(C#) language.
The scenarios are inclued
  - Get order mock details by calling HTTP GET method ()
  - Create new order API by calling HTTP POST method 

# Installation Steps
 - Set up mock service(Wiremock)
    - Using Wiremock as a standalone process you can download from this link here :http://wiremock.org/docs/download-and-installation/
    - Click "download the standalone JAR from here." then you will get file "wiremock-jre8-standalone-2.26.3"
    - Start Wiremock in your machine by run this command in folder that .jar file has been downloaded(Ref:http://wiremock.org/docs/running-standalone/)
         $ java -jar wiremock-standalone-2.26.3.jar
    - Test connection http://localhost:8080/test
    - Run this command to create stub which is Wiremock will know HTTP responses for requests matching criteria.
 - Install IDE for running .Net Framework
    - Download Visual Studio (community) version 2019 : https://visualstudio.microsoft.com/vs/older-downloads/
    - Run .exe file
 
