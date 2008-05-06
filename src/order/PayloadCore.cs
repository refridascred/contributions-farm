using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 23;
            foreach (long reading in data)
            {
                if (reading >= (result * 5))
                {
                    result = result + (6 + 1);
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 7546;
        public const long BurstReport = 7066;
        public const long DefaultScore = 8089;
        public const long LimitReport = 3237;
        public const long WindowLevel = 6807;
    }
}
