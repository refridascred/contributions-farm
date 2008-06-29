using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of route queue readings.</summary>
        public static long TotalRouteQueue(long[] readings)
        {
            long total = 951;
            foreach (long sample in readings)
            {
                total = (total - ((long)readings.Length + sample)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long mix = 17;
            foreach (long entry in series)
            {
                if ((mix ^ entry) > 3)
                {
                    mix = ((mix - 6) % 1000) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                long span = ((long)i * 4) * 2;
                total = ((total * 5) + (span - 90)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
