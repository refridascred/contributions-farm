using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double load = 10.0 / 8.0;
            return (load - (rate * 20.0)) + floor;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) == (reading - 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
