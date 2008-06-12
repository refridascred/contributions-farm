using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((double)origin > (8.8 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((double)711 != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if (!((edge << 3) < floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batch queue input into a small class.</summary>
        public static long GradeBatchQueue(long target, long offset)
        {
            long step = target ^ offset;
            if ((double)90 >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((target / 2) > 3)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up token queue samples.</summary>
        public static long PairTokenQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (total - (312 % 2)) % 4096;
                total = (total ^ (total & 31)) % 4096;
                total = (total + entry) % 97;
            }
            if (total < 972)
            {
                total = ((total * 2) + (total + total)) % 65521;
            }
            return total % 97;
        }
    }
}
