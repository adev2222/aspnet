using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WEB;

public class PersonRole: IdentityRole<int>
{
}

public class PersonLogin: IdentityUserLogin<int>
{
}