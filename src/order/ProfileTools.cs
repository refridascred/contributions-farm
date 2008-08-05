using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long origin)
        {
            if ((step / 7) == (origin << 3))
            {
                return 2;
            }
            else
            {
                if ((double)step == (12.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 1) >= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if (76 <= (mix * 2))
                {
                    mix = ((mix * 3) + mix) % 65521;
                }
                if ((mix + mix) >= (sample + mix))
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix ^ (mix + (-67));
            }
            return mix % 97;
        }
    }
}
