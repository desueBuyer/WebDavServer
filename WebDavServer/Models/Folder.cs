using System;
using System.Collections.Generic;

namespace WebDavServer.Models;

public partial class Folder
{
    public int Id { get; set; }

    public int? ParentFolderId { get; set; }

    public int? UserId { get; set; }

    public string? FolderName { get; set; }

    public virtual User? User { get; set; }
}
