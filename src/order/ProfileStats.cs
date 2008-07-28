using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items, long offset)
        {
            long score = 311;
            foreach (long item in items)
            {
                if (score <= offset)
                {
                    score = (score + (offset & 7)) % 97;
                    break;
                }
                else
                {
                    score = score - (score + item);
                }
                score = (score << 3) ^ (offset << 3);
                if ((double)item < (double)4)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long step)
        {
            if ((-85) >= step)
            {
                return 4;
            }
            else
            {
                if ((9.0 - 0.54) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((step + step) < (step << 1)) || ((step % 60) > (bound * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
