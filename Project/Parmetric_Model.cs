using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Project
{
    class Parmetric_Model : _3D_Model
    {
        public void design_middle(float x, float y, float z)
        {
            int Rad = 10;
            int N = 60;
            float theta = 0;
            float theta_in_rid;
            float diff = 360 / N;
            int ip = 0;
            float xs = x, ys = y, zs = z;
            float tempx = x, tempy = y, tempz = z;
            float ctempx = x, ctempy = y, ctempz = z;
            for (int q = 0; q < 2; q++)
            {
                if (q == 1)
                {
                    xs = x;
                    ys = y;
                    zs = z += 50;
                }
                for (int i = 0; i < 400; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i > 50 && i <= 51)
                    {
                        ys += 2;
                    }
                    if (i > 70 && i <= 71)
                    {
                        ys -= 2;
                    }
                    if (i > 85 && i <= 86)
                    {
                        ys += 20;
                    }
                    if (i >= 92 && i < 93)
                    {
                        ys -= 20;
                    }
                    xs -= 2;
                }
                for (int i = 0; i < 45; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i > 2 && i <= 3)
                    {
                        ys += 4;
                    }
                    if (i > 13 && i <= 14)
                    {
                        ys -= 4;
                    }
                    xs -= 2;
                }
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys - 30 + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta += 95 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys - 30 + yy;
                }
                xs = tempx;
                ys = tempy;
                int t = ip;
                for (float x_th = xs; x_th > -580; x_th -= 10)
                {
                    //y = 100 * (float)(Math.Sin(x_th * Math.PI / 180));
                    float dist = (float)(Math.Sqrt((x_th - xs) * (x_th - xs) + (z - zs) * (z - zs)));
                    float yy = -15 * (float)(Math.Sin(dist * Math.PI / 90));

                    AddPoint(new _3D_Point(x_th, yy + ys, zs));

                    if (ip > 0 && x_th != -580)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    tempy = yy + ys;
                    tempx = x_th;
                }
                ys = tempy;
                xs = -580;
                for (int i = 0; i < 52; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys--;
                    xs -= 7;
                }
                tempy = ys;
                tempx = xs;
                for (int n = 0; n < 3; n++)
                {
                    ys = tempy;
                    for (int i = 0; i < 9; i++)
                    {
                        _3D_Point pnn = new _3D_Point(xs, ys, zs);
                        AddPoint(pnn);
                        if (i > 0)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        ys -= 25;
                    }
                    xs += 5;
                }
                xs = tempx;
                ys += 25;
                for (int i = 0; i < 52; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys += 2;
                    xs += 7;
                }
                xs -= 7;
                ys -= 2;
                for (float x_th = xs; x_th < -440; x_th += 10)
                {
                    //y = 100 * (float)(Math.Sin(x_th * Math.PI / 180));
                    float dist = (float)(Math.Sqrt((x_th - xs) * (x_th - xs) + (z - zs) * (z - zs)));
                    float yy = -25 * (float)(Math.Sin(dist * Math.PI / 90));

                    AddPoint(new _3D_Point(x_th, yy + ys, zs));

                    if (ip > 0 && x_th != -580)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    tempy = yy + ys;
                }
                ys = tempy;
                xs = -440;
                for (int i = 0; i < 55; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 2;
                }
                AddEdge(ip - 1, ip - 268, Color.DarkMagenta);
                _3D_Point pnn2 = new _3D_Point(xs + 25, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                AddEdge(ip, ip - 280, Color.DarkMagenta);
                ip++;
                xs += 25;
                tempx = xs;
                tempy = ys;
                for (int c = 0; c < 2; c++)
                {
                    xs = tempx;
                    for (int i = 0; i < 55; i++)
                    {
                        _3D_Point pnn = new _3D_Point(xs, ys, zs);
                        AddPoint(pnn);
                        if (i > 1)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        xs += 5;
                    }
                    ys += 70;
                }
                pnn2 = new _3D_Point(xs - 5, ys - 140, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ys -= 45;
                xs -= 5;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 17;
                }
                xs = tempx + 15;
                for (int k = 0; k < 21; k++)
                {
                    ys = tempy;
                    for (int i = 0; i < 5; i++)
                    {
                        _3D_Point pnn = new _3D_Point(xs, ys, zs);
                        AddPoint(pnn);
                        if (i == 1 && k == 0)
                        {
                        }
                        else if (i > 1)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        if (i == 1)
                        {
                            ys -= 60;
                        }
                        else if (i == 2)
                        {
                            xs += 10;
                        }
                        else
                        {
                            ys += 60;
                        }
                    }
                    xs += 2;
                }
                ys = tempy;
                xs += 3;
                for (int i = 0; i < 15; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i < 5)
                    {
                        ys -= 10;
                        xs += 6;
                    }
                    else if (i >= 5 && i < 10)
                    {
                        ys -= 10;
                    }
                    else
                    {
                        xs += 5;
                    }
                }
                theta = 0;
                Rad = 150;
                ys += 45;
                xs -= 2;
                ctempx = xs;
                ctempy = ys;
                ctempz = zs;
                //========================================================================================
                //Mag
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        theta_in_rid = (float)(2 * Math.PI * theta / 360);

                        float yy = (float)(Rad * Math.Cos(theta_in_rid));
                        float zz = (float)(Rad * Math.Sin(theta_in_rid));

                        _3D_Point pnn = new _3D_Point(xs, yy + ys, zs + zz);
                        AddPoint(pnn);

                        if (ip > 0 && i > 0)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        if (k > 0 && i == N / 2)
                        {
                            AddEdge(ip, ip - N, Color.DarkMagenta);
                        }
                        if (k > 0 && i % 4 == 0)
                        {
                            AddEdge(ip, ip - N, Color.DarkMagenta);
                        }

                        ip++;
                        theta += diff;
                    }
                    if (k == 0)
                    {
                        xs += 125;
                    }
                    else if (k == 1)
                    {
                        xs += 25;
                    }
                }
                //==============================================================================
                ys += 170;
                xs -= 125;
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys - 30 + yy, zs);
                    AddPoint(pnn);
                    theta += 95 / 20;
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    tempx = xs + xx;
                    tempy = ys - 30 + yy;
                }
                for (int i = 0; i < 21; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i < 5)
                    {
                        xs += 35;
                    }
                    else if (i <= 7)
                    {
                        xs += 7;
                        ys -= 7;
                    }
                    else if (i < 10)
                    {
                        xs -= 7;
                        ys -= 7;
                    }
                    else if (i < 17)
                    {
                        ys -= 15;
                    }
                    else
                    {
                        xs -= 14;
                    }
                }
                xs += 28;
                ys += 15;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 10;
                }
                xs -= 20;
                ys -= 3;
                tempx = xs;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys += 5;
                    xs += 5;
                }
                tempy = xs;
                xs = tempx;
                tempx = tempy;
                ys += 70;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 1)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys -= 5;
                    xs += 5;
                }
                ys -= 60;
                xs = tempx - 25;
                AddEdge(ip - 1, ip - 6, Color.DarkMagenta);
                ip++;
                for (int k = 0; k < 3; k++)
                {
                    xs = tempx - 25;
                    for (int i = 0; i < 10; i++)
                    {
                        _3D_Point pnn = new _3D_Point(xs, ys, zs);
                        AddPoint(pnn);
                        if (i > 1)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        xs += 15;
                    }
                    if (k == 0)
                    {
                        ys += 50;
                    }
                    else if (k == 1)
                    {
                        ys += 15;
                    }
                }
                tempy = ys;
                ys += 80;
                xs -= 15;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                xs += 35;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                ys -= 80;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                ys -= 80;
                xs -= 15;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                xs -= 18;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                ys += 65;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                ys += 16;
                xs += 100;
                pnn2 = new _3D_Point(xs, ys, zs);
                AddPoint(pnn2);
                AddEdge(ip, ip - 4, Color.DarkMagenta);
                ip++;
                AddEdge(ip - 1, 0, Color.DarkMagenta);

            }
            for (int i = 0; i < ip / 2; i++)
            {
                AddEdge(i, i + ip / 2, Color.DarkMagenta);
            }
            theta = 0;
            Rad = 10;
            ys += 35;
            xs += 30;
            zs -= 25;
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float yy = (float)(Rad * Math.Cos(theta_in_rid));
                    float zz = (float)(Rad * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs, yy + ys, zs + zz);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkCyan);
                    }
                    /*else if (j>0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkCyan);
                    }
                    if (j>0)
                    {
                        AddEdge(ip, ip - N, Color.DarkCyan);
                    }*/
                    ip++;
                    theta += diff;
                }
                xs -= 140;
                //designs
                for (int q = 0; q < 5; q++)
                {
                    if (q == 1 || q == 3 || q == 4)
                    {
                        xs -= 45;
                    }
                    else if (q == 2)
                    {
                        xs -= 350;
                    }
                    theta = 90;
                    for (int i = 0; i < N; i++)
                    {
                        theta_in_rid = (float)(2 * Math.PI * theta / 360);

                        float xx = (float)(Rad * Math.Cos(theta_in_rid));
                        float yy = (float)(Rad * Math.Sin(theta_in_rid));

                        _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                        AddPoint(pnn);
                        if (i > 0)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        theta -= 180 / N;
                    }
                    xs -= 25;
                    for (int i = 0; i < N; i++)
                    {
                        theta_in_rid = (float)(2 * Math.PI * theta / 360);

                        float xx = (float)(Rad * Math.Cos(theta_in_rid));
                        float yy = (float)(Rad * Math.Sin(theta_in_rid));

                        _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                        AddPoint(pnn);
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                        if (i == N - 1)
                        {
                            AddEdge(ip, ip - 119, Color.DarkMagenta);
                        }
                        ip++;
                        theta -= 180 / N;
                    }
                }
                float theta2 = 0;
                int Rad2 = 150;
                xs += 380;
                tempx = xs;
                ys -= 25;
                for (int k = 0; k < N; k++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta2 / 360);
                    float yyy = (float)(Rad2 * Math.Cos(theta_in_rid));
                    float zz = (float)(Rad2 * Math.Sin(theta_in_rid));
                    theta2 += diff;
                    /*}
                    for (int q = 0; q < 7; q++)
                    {
                        if (q>0)
                        {
                            ys -= 40;
                        }*/
                    if (k == 0 || k == 5 || k == 10 || k == 15 || k == 20 || k == 25 || k == 30)//||k==35||k==40||k==45||k==50||k==55)
                    {
                        if (k > 0 && k <= 30)
                        {
                            ys -= 40;
                        }
                        else if (k > 30)
                        {
                            ys += 40;
                        }
                        xs = tempx;
                        theta = 90;
                        for (int i = 0; i < N; i++)
                        {
                            theta_in_rid = (float)(2 * Math.PI * theta / 360);

                            float xx = (float)(Rad * Math.Cos(theta_in_rid));
                            float yy = (float)(Rad * Math.Sin(theta_in_rid));

                            _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs - zz);
                            AddPoint(pnn);
                            if (i > 0)
                            {
                                AddEdge(ip, ip - 1, Color.IndianRed);
                            }
                            ip++;
                            theta -= 180 / N;
                        }
                        xs -= 75;
                        for (int i = 0; i < N; i++)
                        {
                            theta_in_rid = (float)(2 * Math.PI * theta / 360);

                            float xx = (float)(Rad * Math.Cos(theta_in_rid));
                            float yy = (float)(Rad * Math.Sin(theta_in_rid));

                            _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs - zz);
                            AddPoint(pnn);
                            AddEdge(ip, ip - 1, Color.IndianRed);
                            if (i == N - 1)
                            {
                                AddEdge(ip, ip - 119, Color.IndianRed);
                            }
                            ip++;
                            theta -= 180 / N;
                        }
                    }
                }

            }
            int ttt = ip;
            ctempx = xs;
            ctempy = ys;
            ctempz = zs;
            for (int q = 0; q < 2; q++)
            {
                if (q>0)
                {
                    zs = z + 50;
                }
                xs = -750;
                ys = -115;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys -= 20;
                }
                ys += 20;
                xs += 30;
                theta = 180;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 95 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx;
                ys = tempy;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 20;
                }
                xs -= 20;
                ys += 30;
                theta = 270;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 95 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx;
                ys = tempy;
                for (int i = 0; i < 7; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys += 20;
                }
                xs -= 80;
                ys -= 33;
                for (int i = 0; i < 4; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys -= 20;
                }
                theta = 180;
                xs += 30;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta += 95 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs += 0;
                theta = 160;
                ys -= 8;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(20 * Math.Cos(theta_in_rid));
                    float yy = (float)(20 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 95 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx - 8;
                ys = tempy + 20;
                for (int i = 0; i < 5; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys += 20;
                }
                xs = ctempx;
                ys = ctempy;
                zs = ctempz;
            }
            int r=(ip-ttt)/2;
            for (int i=0;i<r;i++)
            {
                AddEdge(ttt+i,ttt+(r+i), Color.DarkMagenta);
            }
        }

        //=============================================================
        //End Of Class
    }
}
