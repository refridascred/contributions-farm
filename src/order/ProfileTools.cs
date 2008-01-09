using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 19;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc - (long)i) % 65521) + sample;
                }
                acc = ((acc << 2) ^ ((long)levels.Length - acc)) % 4096;
                if ((acc ^ acc) >= acc)
                {
                    break;
                }
            }
            if (acc > 349)
            {
                acc = ((acc * 4) + (acc % 60)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            if ((step * 4) < (step % 3))
            {
                return 7;
            }
            else
            {
                if (step <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (9.2 + 1.33))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
