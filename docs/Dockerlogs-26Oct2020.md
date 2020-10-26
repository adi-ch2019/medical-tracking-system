PS ~\MedicalTrackingSystem\src> docker-compose -f docker-compose.yml up
Creating network "src_mtsnetwork" with driver "bridge"
Building medicaltrackingsystem.api
Step 1/16 : FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
3.1-buster-slim: Pulling from dotnet/core/aspnet
bb79b6b2107f: Pulling fs layer
fd6f53cfcb35: Pulling fs layer
29b35ed07a14: Downloading [>                                                  ]  15.16kB/1.01729b35ed07a14: Downloading [======>                                            ]  129.2kB/1.017fd6f53cfcb35: Downloading [>                                                  ]  178.4kB/17.06bb79b6b2107f: Downloading [>                                                  ]  276.7kB/27.09MBb35ed07a14: Downloading [============>                                      ]  260.3kB/1.017MB
29b35ed07a14: Downloading [================>                                  ]  342.2kB/1.017fd6f53cfcb35: Downloading [=>                                                 ]  358.6kB/17.06bb79b6b2107f: Downloading [=>                                                 ]  555.2kB/27.09MBb35ed07a14: Downloading [==========================>                        ]  538.8kB/1.017MB
29b35ed07a14: Downloading [==============================>                    ]  620.7kB/1.017fd6f53cfcb35: Downloading [=>                                                 ]  538.8kB/17.06MB
bb79b6b2107f: Downloading [=>                                                 ]  833.7kB/27.09MBb35ed07a14: Downloading [====================================>              ]  751.8kB/1.017fd6f53cfcb35: Downloading [==>                                                ]    719kB/17.06MB
29b35ed07a14: Downloading [=========================================>         ]  850.1kB/1.01729b35ed07a14: Downloading [==========================================>        ]  866.5kB/1.01729b35ed07a14: Downloading [============================================>      ]  899.3kB/1.01729b35ed07a14: Downloading [===============================================>   ]  964.8kB/1.017bb79b6b2107f: Downloading [==>                                                ]  1.112MB/27.09MB
bb79b6b2107f: Downloading [==>                                                ]  1.391MB/27.09MB
bb79b6b2107f: Downloading [===>                                               ]  1.669MB/27.09MB
bb79b6b2107f: Downloading [===>                                               ]  1.948MB/27.09MB
bb79b6b2107f: Downloading [====>                                              ]  2.226MB/27.09MB

bb79b6b2107f: Downloading [====>                                              ]  2.505MB/27.09MB068c4127c7: Downloading [>                                                  ]  325.8kB/31.29bb79b6b2107f: Downloading [=====>                                             ]  2.783MB/27.09MB

bb79b6b2107f: Downloading [=====>                                             ]  3.062MB/27.09bb79b6b2107f: Downloading [=========>                                         ]  5.012MB/27.09bb79b6b2107f: Extracting [========================================>          ]  22.12MB/27.09Mfd6f53cfcb35: Pull complete
29b35ed07a14: Extracting [=>                                                 ]  32.77kB/1.017M29b35ed07a14: Extracting [================>                                  ]  327.7kB/1.017M29b35ed07a14: Extracting [==================================================>]  1.017MB/1.017Mfd068c4127c7: Pull completedc51486f316e: Extracting [>                                                  ]   98.3kB/8.153Mdc51486f316e: Pull complete
Digest: sha256:91ff1ccc425d8d8bbb5cc45714fc2932713784d90e3182841b0000dfba55a043
Status: Downloaded newer image for mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim       
 ---> e3559b2d50bb
Step 2/16 : WORKDIR /app
 ---> Running in 10e8eadde313
Removing intermediate container 10e8eadde313
 ---> 75284230ddb5
Step 3/16 : EXPOSE 80
e4c3d3e4f7b0: Downloading [========================================>          ]  41.14MB/50.4Me4c3d3e4f7b0: Downloading [==========================================>        ]  43.17MB/50.4M101c41d0463b: Extracting [====================>                              ]  3.244MB/7.812M101c41d0463b: Extracting [==========================================>        ]  6.685MB/7.812M8275efcd805f: Extracting [=========================================>         ]  8.389MB/9.996M8275efcd805f: Extracting [==================================================>]  9.996MB/9.996M751620502a7a: Extracting [================================================>  ]  49.81MB/51.83M751620502a7a: Extracting [=================================================> ]  51.38MB/51.83M751620502a7a: Pull complete
8e306865fd07: Pull complete
9d2f53e752c2: Pull complete143a93e01eba: Extracting [>                                                  ]  163.8kB/13.26M143a93e01eba: Pull complete
Digest: sha256:bfd6083e9cd36b37b2a4e9f1722cc958b6654fa96cb3d84ef78492ecf00dcd32
Status: Downloaded newer image for mcr.microsoft.com/dotnet/core/sdk:3.1-buster
 ---> 5fe503d51830
Step 5/16 : WORKDIR /src
 ---> Running in 60ade2bff8ec
Removing intermediate container 60ade2bff8ec
 ---> ee37a6792e31
Step 6/16 : COPY ["MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj", "MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/"]   
 ---> 8f8dbb99f1c2
Step 7/16 : RUN dotnet restore "MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj"
 ---> Running in 5eaea0944f30
  Determining projects to restore...
  Restored /src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj (in 11.46 sec).
Removing intermediate container 5eaea0944f30
 ---> e861b3fdc17b
Step 8/16 : COPY . .
 ---> 14e394448197
Step 9/16 : WORKDIR "/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api"
 ---> Running in 3ba903eff4c8
Removing intermediate container 3ba903eff4c8
 ---> ab03cee81b7b
Step 10/16 : RUN dotnet build "medicaltrackingsystem.api.csproj" -c Release -o /app/build     
 ---> Running in 4b35974f63ae
Microsoft (R) Build Engine version 16.7.0+7fb82e5b2 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
Controllers/MTSController.cs(23,86): warning CS0472: The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?' [/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj]
Controllers/MTSController.cs(23,60): warning CS0472: The result of the expression is always 'true' since a value of type 'double' is never equal to 'null' of type 'double?' [/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj]      
  medicaltrackingsystem.api -> /app/build/medicaltrackingsystem.api.dll

Build succeeded.

Controllers/MTSController.cs(23,86): warning CS0472: The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?' [/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj]
Controllers/MTSController.cs(23,60): warning CS0472: The result of the expression is always 'true' since a value of type 'double' is never equal to 'null' of type 'double?' [/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj]      
    2 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.89
Removing intermediate container 4b35974f63ae
 ---> cb97cc1f4744

Step 11/16 : FROM build AS publish
 ---> cb97cc1f4744
Step 12/16 : RUN dotnet publish "medicaltrackingsystem.api.csproj" -c Release -o /app/publish
 ---> Running in 5178d58d4f25
Microsoft (R) Build Engine version 16.7.0+7fb82e5b2 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  medicaltrackingsystem.api -> /src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/bin/Release/netcoreapp3.1/medicaltrackingsystem.api.dll
  medicaltrackingsystem.api -> /app/publish/
Removing intermediate container 5178d58d4f25
 ---> 24da4ff2892b

Step 13/16 : FROM base AS final
 ---> 9931d91f9b45
Step 14/16 : WORKDIR /app
 ---> Running in bc84dc56d2be
Removing intermediate container bc84dc56d2be
 ---> facaea9abb39
Step 15/16 : COPY --from=publish /app/publish .
 ---> f53a9296c3a9
Step 16/16 : ENTRYPOINT ["dotnet", "medicaltrackingsystem.api.dll"]
 ---> Running in 0a127d3e1fd7
Removing intermediate container 0a127d3e1fd7
 ---> 6d8d52bdc4f8

Successfully built 6d8d52bdc4f8
Successfully tagged medicaltrackingsystemapi:latest
WARNING: Image for service medicaltrackingsystem.api was built because it did not already exist. To rebuild this image you must use `docker-compose build` or `docker-compose up --build`.  
Building medicaltrackingsystem.ui
cbdbe7a5bc2a: Pull completec36334c36d30: Extracting [=================================================> ]  35.68MB/35.97Mc36334c36d30: Extracting [==================================================>]  35.97MB/35.97Mc36334c36d30: Pull complete
dc731be5fee1: Pull complete
8a23f73dde1a: Pull complete
Digest: sha256:90dfaf5806a607e81cc81b42b474626612c9271eee7a4fc6644ce6299348425a
Status: Downloaded newer image for node:alpine
 ---> 1e8b781248bb
Step 2/8 : LABEL author="Aditya Naidu"
 ---> Running in acfe5cf3165d
Removing intermediate container acfe5cf3165d
 ---> 473d24e7df67
Step 3/8 : WORKDIR /app
 ---> Running in 746903e01dd2
Removing intermediate container 746903e01dd2
 ---> a268ab88bdc8
Step 4/8 : COPY . /app
 ---> cc219fa9ea10
Step 5/8 : RUN npm install
 ---> Running in 4f22786ca3b0

up to date in 4s

found 0 vulnerabilities
npm notice 
npm notice New patch version of npm available! 7.0.3 -> 7.0.5
npm notice Changelog: <https://github.com/npm/cli/releases/tag/v7.0.5>
npm notice Run `npm install -g npm@7.0.5` to update!
npm notice
Removing intermediate container 4f22786ca3b0
 ---> bcdd6cd39743
Step 6/8 : WORKDIR /app
 ---> Running in 964de77d4db2
Removing intermediate container 964de77d4db2
 ---> 9058952b17e9
Step 7/8 : COPY . /app
 ---> b4704cd1b131
Step 8/8 : RUN npm run --prod
 ---> Running in 861f1f42bd72
Removing intermediate container 861f1f42bd72
 ---> 137c652364d8

Successfully built 137c652364d8
Successfully tagged medicaltrackingsystemui:latest
WARNING: Image for service medicaltrackingsystem.ui was built because it did not already exist. To rebuild this image you must use `docker-compose build` or `docker-compose up --build`.   
Creating src_medicaltrackingsystem.api_1 ... done
Creating src_medicaltrackingsystem.ui_1  ... done
Attaching to src_medicaltrackingsystem.api_1, src_medicaltrackingsystem.ui_1
medicaltrackingsystem.api_1  | info: Microsoft.Hosting.Lifetime[0]
medicaltrackingsystem.api_1  |       Now listening on: http://[::]:80
medicaltrackingsystem.api_1  | info: Microsoft.Hosting.Lifetime[0]
medicaltrackingsystem.api_1  |       Application started. Press Ctrl+C to shut down.
medicaltrackingsystem.api_1  | info: Microsoft.Hosting.Lifetime[0]
medicaltrackingsystem.api_1  |       Hosting environment: Production
medicaltrackingsystem.api_1  | info: Microsoft.Hosting.Lifetime[0]
medicaltrackingsystem.api_1  |       Content root path: /app