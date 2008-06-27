using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first route window entry that matches the target.</summary>
        public static long LookupRouteWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit format account readings against a rule.</summary>
        public static long MeasureFormatAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (6 > tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
