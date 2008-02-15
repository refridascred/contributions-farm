using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up channel record samples.</summary>
        public static long CompareChannelRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8410;
        public const double BaseFarm = 56.6;
        public const long StepFarm = 4089;
        public const long RetryFarm = 6625;
        public const long BurstScore = 7244;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long bound)
        {
            if (!((741 - bound) == (612 + origin)))
            {
                return 6;
            }
            else
            {
                if ((origin % 2) != (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if (origin >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 6139;
        public const string MaxEditor = "local";
        public const long CacheEditor = 4230;
        public const double BurstEditor = 18.5;
        public const long RetryLevel = 9313;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
