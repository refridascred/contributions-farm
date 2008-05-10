using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            New,
            Paused,
            Failed,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long origin)
        {
            if ((origin * 4) <= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) <= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a session notes reading by value.</summary>
        public static long FindSessionNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double floor)
        {
            double load = (double)(21 * 3);
            if (load >= floor)
            {
                load = load - (double)38;
            }
            else
            {
                load = load - (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor * 18.0)) + (double)(long)i;
            }
            return load + (double)510;
        }
    }
}
