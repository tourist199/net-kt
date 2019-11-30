using AppG4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Service
{
    public class HistoryLearningService
    {
        /// <summary>
        /// Lấy danh sách quá trình học tập của một sinh viên dựa vào idStudent
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Danh sách quá trình học tập của sinh viên</returns>
        public static List<HistoryLearning> GetListHistoryLearning(string idStudent)
        {
            List<HistoryLearning> histories = new List<HistoryLearning>();
            for (int i = 1; i <= 12; i++)
            {
                HistoryLearning history = new HistoryLearning
                {
                    ID = i.ToString(),
                    YearFrom = 2000 + i,
                    YearEnd = 2001 + i,
                    SchoolName = "Phan Bội Châu",
                    IDStudent = idStudent
                };
                histories.Add(history);
            }
            return histories;
        }

        /// <summary>
        /// Lấy danh sách quá trình học tập của một sinh viên dựa vào file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="idStudent"></param>
        /// <returns>Danh sách quá trình học tập của 1 sv</returns>
        public static List<HistoryLearning> GetListHistoryLearning(string path, string idStudent)
        {
            List<HistoryLearning> rs = new List<HistoryLearning>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach(var line in lines)
                {
                    //Line: ma#tuNam#denNam#noiHoc#masv
                    var items = line.Split(new char [] { '#'});

                    HistoryLearning history = HistoryLearning.Parse(line);
                    //    new HistoryLearning
                    //{
                    //    ID = items[0],
                    //    YearFrom = int.Parse(items[1]),
                    //    YearEnd = int.Parse(items[2]),
                    //    SchoolName = items[3],
                    //    IDStudent = items[4]
                    //};
                    if (history.IDStudent == idStudent)
                        rs.Add(history);
                }
            }
            return rs;
        }
        public static void Remove (string path, HistoryLearning history)
        {
            List<string> rs = new List<string>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = HistoryLearning.Parse(line);
                    if (data.ID != history.ID)
                        rs.Add(line);
                }
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");

        }

        public static void Add(string path, HistoryLearning history)
        {
            List<string> rs = new List<string>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    rs.Add(line);
                }
                rs.Add(HistoryLearning.Parse(history));
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");

        }

        public static void Update(string path, HistoryLearning history)
        {
            List<string> rs = new List<string>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = HistoryLearning.Parse(line);
                    if (data.ID != history.ID)
                        rs.Add(line);
                    else
                        rs.Add(HistoryLearning.Parse(history));
                }
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");

        }
    }
}