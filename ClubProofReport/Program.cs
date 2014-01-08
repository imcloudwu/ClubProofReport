﻿using FISCA;
using FISCA.Permission;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubProofReport
{
    public class Program
    {
        [MainMethod()]
        static public void Main()
        {
            RibbonBarItem Print = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "資料統計"];
            Print["報表"]["社團相關報表"]["社團參與證明單(高雄)"].Enable = Permissions.社團參與證明單權限_高雄;
            Print["報表"]["社團相關報表"]["社團參與證明單(高雄)"].Click += delegate
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
            };

            Catalog detail1 = RoleAclSource.Instance["學生"]["報表"];
            detail1.Add(new RibbonFeature(Permissions.社團參與證明單_高雄, "社團參與證明單(高雄)"));
        }
    }
}
