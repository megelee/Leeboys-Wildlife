﻿
namespace LeeboysWildlife.Models;

public class WorkOrder
{
    public int Id { get; set; }
    public int UserProfileId { get; set; }
    public int? EmployeeId { get; set; }
    public bool Emergency { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateCompleted { get; set; }
    public int? ServiceId { get; set; }
    public string Description { get; set; }

    public List <UserProfile>? UserProfiles { get; set; }
    public Employee? Employee { get; set; }
    public Service? Service { get; set; }
}
