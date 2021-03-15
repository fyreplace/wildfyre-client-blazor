#!/bin/bash

curl -sL https://dot.net/v1/dotnet-install.sh > /tmp/dotnet-install.sh
bash /tmp/dotnet-install.sh -c Current -i .dotnet
./.dotnet/dotnet publish -c Release -o published
