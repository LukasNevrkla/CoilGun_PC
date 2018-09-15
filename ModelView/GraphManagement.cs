using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace CoilGun_PC.ModelView
{
    class GraphManagement
    {
        public SeriesCollection SeriesCollection { get; set; }

       List<ChartValues<ObservablePoint>> Points_list = new List<ChartValues<ObservablePoint>>();

        public GraphManagement()
        {
            SeriesCollection = new SeriesCollection {};
        }

        //return index of serie//
        public int CreateLineSeries (string title)
        {
            ChartValues<ObservablePoint> points = new ChartValues<ObservablePoint>();

            Points_list.Add(points);

            SeriesCollection.Add(new LineSeries
            {
                Title = title,
                Values = points,
                PointGeometry = null,
            });

            return SeriesCollection.Count - 1;
        }

        public void SetDataInSerie(int index, List<double> _X, List<double> _Y)
        {
            int size = Math.Max(_X.Count, _Y.Count);

            Points_list[index].Clear();
            for (int i=0;i<size;i++)
            {
                Points_list[index].Add(new ObservablePoint
                {
                    X = _X[i],
                    Y = _Y[i]
                });
            }
        }

        public void AddDataToSerie(int index, List<double> _X, List<double> _Y)
        {
            int size = Math.Max(_X.Count, _Y.Count);
            int offset = Points_list[index].Count;

            for (int i = 0; i < size; i++)
            {
                Points_list[index].Add(new ObservablePoint
                {
                    X = _X[i] + offset,
                    Y = _Y[i]
                });
            }
        }
    }
}
