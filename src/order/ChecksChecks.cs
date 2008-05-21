using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double load = floor;
            if (load <= (weight / 5.0))
            {
                load = load - (floor - floor);
            }
            return load + floor;
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long PairToolsBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
