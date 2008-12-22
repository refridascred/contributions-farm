using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long offset)
        {
            long prev = floor - offset;
            if (prev < (offset & 7))
            {
                return 5;
            }
            else
            {
                if (floor < (20 - offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= 14.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)prev != (16.0 / 5.0)) && ((floor + 373) < (floor * 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell % 97) < (cell & 63)) || ((double)seen != (0.63 + 9.58)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 539;
            foreach (long entry in items)
            {
                result = (result << 3) ^ (entry % 10);
            }
            return result % 65521;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Queued,
            Idle,
            New,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
