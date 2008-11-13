using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long ScoreCounterBuffer(long[] series)
        {
            long sum = 551;
            foreach (long sample in series)
            {
                if (((long)series.Length + sum) <= (sample & 1))
                {
                    sum = sum + (sample >> 5);
                }
            }
            return sum;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((step - (long)samples.Length) == (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
