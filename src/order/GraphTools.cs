using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a command cluster figure with a bias.</summary>
        public static double AdjustCommandCluster(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (scale - floor)) - (double)(long)i;
            }
            return rate - 9.6;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((seed < (5 & 31)) || (seed > (seed - count)))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Closed,
            Paused,
        }
    }
}
