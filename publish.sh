#!/bin/bash

mkdir -p ./publish_cli
if ! test -f ./publish_cli/yt-dlp_linux; then
  wget https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp_linux -O ./publish_cli/yt-dlp_linux
fi

rm -f ./publish_cli/ytdl

echo "Publish cli..."
cd ./src/Cli
dotnet publish -c Release -o ../../publish_cli -r linux-x64  /p:IncludeAllContentForSelfExtract=true /p:PublishSingleFile=true /p:PublishTrimmed=true /p:DebugType=None /p:DebugSymbols=false --self-contained true
