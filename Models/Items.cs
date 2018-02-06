using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    private string _title;
    private string _description;
    private string _contact;


    private static List<Item> _instances = new List<Item> {};

    public Item (string title, string description, string contact )
    {
      _title = title;
      _description = description;
      _contact = contact;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetContact()
    {
      return _contact;
    }
    public void SetContact(string newContact)
    {
      _contact = newContact;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
