using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 789;
            foreach (long cell in values)
            {
                if ((double)cell >= (5.4 + 3.0))
                {
                    score = (score ^ (score << 3)) % 255;
                    score = (score ^ (cell << 3)) % 65521;
                }
                score = (score ^ (score - cell)) % 97;
                if ((cell + score) > (cell + cell))
                {
                    break;
                }
            }
            if (score > 107)
            {
                score = ((score << 2) ^ (score + 2)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double load = span;
            if (load >= (span + 1.16))
            {
                load = load - ratio;
            }
            else
            {
                load = load + (double)79;
            }
            return load + 1.5;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
