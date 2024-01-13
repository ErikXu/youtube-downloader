#!/bin/bash

rm -rf ./publish_cli

echo "Publish cli..."
cd ./src/Cli
dotnet publish -c Release -o ../../publish_cli -r linux-x64  /p:IncludeAllContentForSelfExtract=true /p:PublishSingleFile=true /p:PublishTrimmed=true /p:DebugType=None /p:DebugSymbols=false --self-contained true
