using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCLocker.Business
{
    public class ChartController: MainTabController
    {
        public ChartController(MainTab view) : base(view)
        {
            using(var db = new UMCLOCKEREntities())
            {
                var locker = db.Lockers.ToList();
                var shoes = db.Shoes.ToList();

                var totalFemaleLocker = locker.Where(m => m.locker_type == Constants.FEMALE);
                var totalFemaleLockerInUse = totalFemaleLocker.Where(m => m.state == Constants.STATE_USED).Count();
                var totalFemaleLockerAvaiable = totalFemaleLocker.Where(m => m.state == Constants.STATE_AVAIABLE).Count();

                // tu locker nu
                view.ChartLockerNu.Titles.Add("Biểu đồ sử dụng khóa Locker Nữ");
                view.ChartLockerNu.Series["Locker"].Points.AddXY("Tổng", totalFemaleLocker.Count().ToString());
                view.ChartLockerNu.Series["Locker"].Points.AddXY("Đang sử dụng", totalFemaleLockerInUse.ToString());
                view.ChartLockerNu.Series["Locker"].Points.AddXY("Tồn", totalFemaleLockerAvaiable.ToString());
                view.ChartLockerNu.Series["Locker"].Points[0].Label = totalFemaleLocker.Count().ToString();
                view.ChartLockerNu.Series["Locker"].Points[1].Label = totalFemaleLockerInUse.ToString();
                view.ChartLockerNu.Series["Locker"].Points[2].Label = totalFemaleLockerAvaiable.ToString();
                view.ChartLockerNu.Series["Locker"].Points[0].Color = Color.SteelBlue;
                view.ChartLockerNu.Series["Locker"].Points[1].Color = Color.DarkRed;
                view.ChartLockerNu.Series["Locker"].Points[2].Color = Color.YellowGreen;

                // tu shoes nu

                var totalFemaleShoes = shoes.Where(m => m.shoes_type == Constants.FEMALE);
                var totalFemaleShoesInUse = totalFemaleShoes.Where(m => m.state == Constants.STATE_USED).Count();
                var totalFemaleShoesAvaiable = totalFemaleShoes.Where(m => m.state == Constants.STATE_AVAIABLE).Count();

                view.ChartShoesNu.Titles.Add("Biểu đồ sử dụng khóa tủ giày Nữ");
                view.ChartShoesNu.Series["Locker"].Points.AddXY("Tổng", totalFemaleShoes.Count().ToString());
                view.ChartShoesNu.Series["Locker"].Points.AddXY("Đang sử dụng", totalFemaleShoesInUse.ToString());
                view.ChartShoesNu.Series["Locker"].Points.AddXY("Tồn", totalFemaleShoesAvaiable.ToString());
                view.ChartShoesNu.Series["Locker"].Points[0].Label = totalFemaleShoes.Count().ToString();
                view.ChartShoesNu.Series["Locker"].Points[1].Label = totalFemaleShoesInUse.ToString();
                view.ChartShoesNu.Series["Locker"].Points[2].Label = totalFemaleShoesAvaiable.ToString();
                view.ChartShoesNu.Series["Locker"].Points[0].Color = Color.SteelBlue;
                view.ChartShoesNu.Series["Locker"].Points[1].Color = Color.DarkRed;
                view.ChartShoesNu.Series["Locker"].Points[2].Color = Color.YellowGreen;

                // tu locker nam

                var totalMaleLocker = locker.Where(m => m.locker_type == Constants.MALE);
                var totalMaleLockerInUse = totalFemaleLocker.Where(m => m.state == Constants.STATE_USED).Count();
                var totalMaleLockerAvaiable = totalFemaleLocker.Where(m => m.state == Constants.STATE_AVAIABLE).Count();

                view.ChartLockerNam.Titles.Add("Biểu đồ sử dụng khóa Locker Nam");
                view.ChartLockerNam.Series["Locker"].Points.AddXY("Tổng", totalMaleLocker.Count().ToString());
                view.ChartLockerNam.Series["Locker"].Points.AddXY("Đang sử dụng", totalMaleLockerInUse.ToString());
                view.ChartLockerNam.Series["Locker"].Points.AddXY("Tồn", totalMaleLockerAvaiable.ToString());
                view.ChartLockerNam.Series["Locker"].Points[0].Label = totalMaleLocker.Count().ToString();
                view.ChartLockerNam.Series["Locker"].Points[1].Label = totalMaleLockerInUse.ToString();
                view.ChartLockerNam.Series["Locker"].Points[2].Label = totalMaleLockerAvaiable.ToString();
                view.ChartLockerNam.Series["Locker"].Points[0].Color = Color.SteelBlue;
                view.ChartLockerNam.Series["Locker"].Points[1].Color = Color.DarkRed;
                view.ChartLockerNam.Series["Locker"].Points[2].Color = Color.YellowGreen;

                // tu shoes nam
                var totalMaleShoes = shoes.Where(m => m.shoes_type == Constants.MALE);
                var totalMaleShoesInUse = totalFemaleShoes.Where(m => m.state == Constants.STATE_USED).Count();
                var totalMaleShoesAvaiable = totalFemaleShoes.Where(m => m.state == Constants.STATE_AVAIABLE).Count();

                view.ChartShoesNam.Titles.Add("Biểu đồ sử dụng khóa tủ giày nam");
                view.ChartShoesNam.Series["Locker"].Points.AddXY("Tổng", totalMaleShoes.Count().ToString());
                view.ChartShoesNam.Series["Locker"].Points.AddXY("Đang sử dụng", totalMaleShoesInUse.ToString());
                view.ChartShoesNam.Series["Locker"].Points.AddXY("Tồn", totalMaleShoesAvaiable.ToString());
                view.ChartShoesNam.Series["Locker"].Points[0].Label = totalMaleShoes.Count().ToString();
                view.ChartShoesNam.Series["Locker"].Points[1].Label = totalMaleShoesInUse.ToString();
                view.ChartShoesNam.Series["Locker"].Points[2].Label = totalMaleShoesAvaiable.ToString();
                view.ChartShoesNam.Series["Locker"].Points[0].Color = Color.SteelBlue;
                view.ChartShoesNam.Series["Locker"].Points[1].Color = Color.DarkRed;
                view.ChartShoesNam.Series["Locker"].Points[2].Color = Color.YellowGreen;
            }
        
        }


        public void bgwChart_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        public void bgwChart_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

    }
}
