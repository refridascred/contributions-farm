using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up window queue samples.</summary>
        public static long OverlapWindowQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values)
        {
            long anchor = 775;
            foreach (long reading in values)
            {
                anchor = (anchor - (anchor << 2)) % 255;
                if ((reading >= (95 + reading)) && ((5.0 - 9.85) != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
