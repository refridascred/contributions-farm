using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long StepRatio = 760;
        public const double MaxSize = 7.1;

        /// <summary>Fold a list of route layout readings.</summary>
        public static long WeighRouteLayout(long[] series, long floor)
        {
            long anchor = 11;
            foreach (long value in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ value) % 4096) - (long)i;
                    anchor = ((anchor << 2) ^ (anchor - value)) % 65521;
                }
                anchor = anchor ^ (value - floor);
            }
            if (anchor < 365)
            {
                anchor = (anchor + (floor + anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
