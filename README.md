# Code-challenge
## Section 1: Test Strategies
Please see test plan and test scenarios in here https://github.com/ptuampitak/code-challenge/blob/master/01_food_delivery_charge_test.xlsx
In .excel file you will see 3 tabs which are
 - Food delivery testcases technique tab contains Boundary value analysis(BVA) and Decision testing table 
 - Food delivery automation test contains testcases should be covered by automation test(Expect success& failed cases) and reasons
 - Explanation details
 
 ## Section 2: Mobile Test design
 Please see test scenarios in here https://github.com/ptuampitak/code-challenge/tree/master/MobileTestSpec contain files
  - CheckRegisterFlow.yml
  - CheckLoginFlow.yml
  - CheckAddNewCard.yml
  - CheckPaymentFromPushNoti.yml
When we do Behaviour-Driven Development with Test-Spec we use concrete examples to specify what we want the software to do. Scenarios are written before automation test code.In the nutshall,From automation test scripts should read action,step and scenarios from test spec.

## Section 3 : REST API Test Automation
Automation script for calling Wiremock API(https://github.com/ptuampitak/code-challenge/tree/master/OmiseTest)
This automation test script implemented by .NET(C#) language.
The scenarios are inclued
  - Get order mock details by calling HTTP GET method ()
  - Create new order API by calling HTTP POST method 

# Installation Steps
please seen in https://github.com/ptuampitak/code-challenge/blob/master/InstallationSteps.pdf which is contains
 - Set up mock service(Wiremock) API
 - Install IDE for running .Net Framework
    - Download Visual Studio (community) version 2019 : https://visualstudio.microsoft.com/vs/older-downloads/
    - Run .exe file
 
