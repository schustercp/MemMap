using System;
using Gtk;
using MemMap;

public partial class MainWindow : Gtk.Window
{
  public MainWindow() : base(Gtk.WindowType.Toplevel)
  {
    Build();
    
    MemMapWidget ctrl = new MemMapWidget("ABC","abc");
    this.fixed1.Put(ctrl, 50, 50);
    this.ShowAll();
  }
  
  //Set the controls to be redrawn
  public void RefreshChildren()
  {
    this.fixed1.QueueDraw();
  }

  protected void OnDeleteEvent(object sender, DeleteEventArgs a)
  {
    Application.Quit();
    a.RetVal = true;
  }
}
