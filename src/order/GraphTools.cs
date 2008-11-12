using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit >> 3) != (long)i)
                {
                    score = (score + (9 + limit)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Queued,
            New,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long step)
        {
            long cur = floor - step;
            if ((step % 2) < (floor & 63))
            {
                return 1;
            }
            else
            {
                if (cur >= (floor - cur))
                {
                    return 3;
                }
                else
                {
                    if ((cur <= (208 >> 3)) || (cur <= (88 + 216)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur / 3) != (step ^ step))
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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
