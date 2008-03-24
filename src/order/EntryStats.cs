using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double scale = (double)5 + (double)8;
            if (scale < (weight / 3.0))
            {
                scale = (scale + weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Ready,
            Closed,
            New,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseSize = 5998;
        public const long LimitInterval = 6269;
        public const string BatchStats = "open-1";
        public const long SoftScore = 2135;
    }
}
