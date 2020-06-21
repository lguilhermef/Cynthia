dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=Cynthia;Integrated Security=SSPI;" Microsoft.EntityFrameworkCore.SqlServer -c CynthiaDbContext -f -o Models\Db

pause