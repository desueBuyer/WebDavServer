using System;
using System.Collections.Generic;

namespace WebDavServer.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();
}
