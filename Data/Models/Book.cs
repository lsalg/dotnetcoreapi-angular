using System;

namespace dot_net_core_ex.Data;

public class Book
{
    public int Id {get;set;}
    public string Title {get;set;}
    public string Author {get;set;}
    public string Description {get;set;}
    public double? Rate {get;set;}
    public DateTime? DateStart {get;set;}
    public DateTime? DateRead {get;set;}


}