Write-host -ForegroundColor Yellow "Starting Unit tests"
Push-Location
cd .\test\LawnMowers.Tests\
dotnet test
Pop-Location