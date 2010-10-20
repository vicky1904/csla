﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla.Xaml;

namespace WpfUI
{
  public class OrderVm : ViewModel<BusinessLibrary.Order>
  {
    public OrderVm()
    {
      DoRefresh("NewOrder");
    }

    protected override void OnError(Exception error)
    {
      Bxf.Shell.Instance.ShowError(error.Message, "Error");
    }
  }
}
