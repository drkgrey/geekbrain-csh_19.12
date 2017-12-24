using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csh_19._12
{
    class point
    {
        public int x;
        public int y;
        public int step;
        public bool check;
        public bool wall;
        public point()
        {
            x = 0;
            y = 0;
            step = 0;
            wall = false;
            check = false;
        }
        public point(int x,int y, int step, bool wall, bool check)
        {
            this.x = x;
            this.y = y;
            this.step = step;
            this.wall = wall;
            this.check = check;
        }
        public List<point> CreateMap(int[,] mass)
        {
            List<point> map = new List<point>();
            for (int i = 0; i< mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] == -2)
                    {
                        map.Add(new point(i, j, -1, true, false));
                    }
                    else
                        map.Add(new point(i, j, -1, false, false));
                }
            }
            return map;
        }
        public bool IsPath(List<point> map) //+ Добавить исключение при невозможности найти выход
        {
            map[0].step = 0;
            map[0].check = true;
            int i = 0;
            var n = map.FindIndex(delegate (point obj) { return obj.x == 199 && obj.y == 199; });
            while (!map[n].check)
            {
                List<point> bystep = map.FindAll(delegate (point obj)
                {
                    return (obj.step == i); 
                });
            foreach (var el in bystep)
                {
                    List<point> isnear = map.FindAll(delegate (point obj)
                    {
                        return (/*(obj.x == el.x + 1 && obj.y == el.y + 1) ||*/ (obj.x == el.x && obj.y == el.y + 1) ||
                        (obj.x == el.x + 1 && obj.y == el.y) /*|| (obj.x == el.x + 1 && obj.y == el.y - 1) || (obj.x == el.x - 1 && obj.y == el.y + 1)*/
                        || (obj.x == el.x - 1 && obj.y == el.y) || (obj.x == el.x && obj.y == el.y - 1) /*|| (obj.x == el.x - 1 && obj.y == el.y - 1)*/)
                        && (!obj.check)&&(!obj.wall);
                         
                    });
                    foreach (var el1 in isnear)
                    {
                        el1.step = i + 1;
                        el1.check = true;
                    }
                }
                i++;
            }
            if (map[n].check) return true; else return false;
              }
        public List<point> ShowPath(List<point> map)
        {
            List<point> path = new List<point>();
            var ac = map[map.FindIndex(delegate (point obj) { return obj.x == 199 && obj.y == 199; })];
            path.Add(ac);
            while (ac.step != 1)
            {
                var bc = map.FindAll(delegate (point obj) {
                    return (((obj.step == ac.step - 1 && obj.x == ac.x && obj.y == ac.y- 1) || (obj.step == ac.step - 1 && obj.x == ac.x - 1 && obj.y == ac.y)||
                    (obj.step == ac.step - 1 && obj.x == ac.x && obj.y == ac.y+1)|| (obj.step == ac.step - 1 && obj.x == ac.x+ 1 && obj.y == ac.y) /*||
                    (obj.step == ac.step - 1 && obj.x == ac.x - 1 && obj.y == ac.y - 1) || (obj.step == ac.step - 1 && obj.x == ac.x + 1 && obj.y == ac.y - 1) ||
                    (obj.step == ac.step - 1 && obj.x == ac.x + 1 && obj.y == ac.y + 1) || (obj.step == ac.step - 1 && obj.x == ac.x - 1 && obj.y == ac.y + 1)*/)
                    );
                });
                bc.OrderByDescending(x => x).ThenBy(y=>y);
                        path.Add(bc[0]); ac = bc[0];
            }
            return path;
        }
    }
}
