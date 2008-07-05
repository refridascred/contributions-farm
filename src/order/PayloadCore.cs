using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long ScoreProfileNotes(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score ^ target) % 1000;
                if ((score + cell) >= (877 << 2))
                {
                    score = (score + (score + target)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long acc = -941;
            foreach (long cell in data)
            {
                if ((11.0 - 2.67) >= (double)cell)
                {
                    acc = acc ^ (223 + acc);
                }
                if (((long)data.Length + cell) > (57 - cell))
                {
                    break;
                }
            }
            if (acc > 94)
            {
                acc = acc - (acc / 7);
            }
            return acc;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long WeighWindowBuffer(long[] items)
        {
            long anchor = -29;
            foreach (long sample in items)
            {
                anchor = (anchor + (34 * 4)) - sample;
            }
            if (anchor < 85)
            {
                anchor = (anchor + (anchor + anchor)) % 101;
            }
            return anchor;
        }
    }
}
