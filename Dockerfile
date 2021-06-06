FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY ./ /app/

ENTRYPOINT ["dotnet", "run", "--project", "./WsbEstate.Api"]