﻿// Decompiled with JetBrains decompiler
// Type: IsoPack.AddEditForm
// Assembly: IsoTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A40E7877-59D4-416C-9526-ACFD66F37CC4
// Assembly location: C:\Program Files\Iso Tool\IsoTool.exe

using System.Windows.Forms;

namespace IsoPack
{
  public class AddEditForm : Form
  {
    public FormMode FormMode { get; set; } = FormMode.Edit;

    public virtual void UpdateUI(bool b)
    {
    }
  }
}
