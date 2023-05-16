namespace StudentsApi.Models;

[EnableCors("Policy")]
public class StudentService
{
    public static async Task<IResult> GetAllStudents(SchoolDbContext db)
    {
        return TypedResults.Ok(await db.Students.ToListAsync());
    }

    public static async Task<IResult> GetStudentById(int id, SchoolDbContext db)
    {
        return TypedResults.Ok(await db.Students.FindAsync(id)
            is Student student ? Results.Ok(student) : Results.NotFound());
    }

}
