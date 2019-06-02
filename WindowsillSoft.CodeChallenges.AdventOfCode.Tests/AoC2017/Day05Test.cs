﻿using NUnit.Framework;
using WindowsillSoft.CodeChallenges.AdventOfCode._2017;

namespace WindowsillSoft.CodeChallenges.AdventOfCode.Tests.AoC2017
{
    public class Day05Test : TestBase<Day05>
    {
        [Test,
            TestCase("0\n3\n0\n1\n-3", "5")]
        public void Part1(string input, string output)
        {
            var solver = GetSolver(input);
            Assert.That(solver.ExecutePart1(), Is.EqualTo(output));
        }

        [Test,
            TestCase("0\n3\n0\n1\n-3", "10")]
        public void Part2(string input, string output)
        {
            var solver = GetSolver(input);
            Assert.That(solver.ExecutePart2(), Is.EqualTo(output));
        }

        [Test]
        public void FullRun()
        {
            var solver = GetSolver("0\n0\n0\n2\n0\n-3\n2\n0\n1\n-3\n-8\n0\n2\n-12\n-11\n-11\n-8\n-1\n-8\n0\n2\n-1\n2\n-1\n-9\n2\n-6\n2\n-6\n-3\n-12\n-28\n-3\n1\n-26\n0\n-27\n-29\n-13\n-27\n-20\n-6\n-18\n-1\n-36\n-29\n-42\n-46\n-5\n-13\n-28\n-33\n-42\n-52\n-18\n-34\n-29\n-53\n-36\n-50\n-31\n-43\n-10\n-7\n-48\n2\n-34\n-36\n-30\n-48\n-60\n-6\n-13\n-11\n-39\n-16\n-10\n-68\n-48\n-20\n-21\n-30\n-41\n2\n-66\n-26\n-72\n-15\n-46\n-4\n-13\n-49\n-15\n-23\n-68\n-34\n-64\n-71\n-78\n-76\n-2\n-74\n-45\n-50\n-101\n-4\n-13\n0\n-94\n-102\n-50\n-13\n-108\n-66\n-39\n-56\n-7\n-54\n-90\n-11\n-92\n-53\n-67\n-6\n-56\n-3\n-4\n-105\n-32\n-2\n-60\n-9\n-128\n-55\n-25\n-109\n-24\n-83\n-26\n-121\n-53\n-139\n-124\n-137\n-94\n-130\n-28\n-135\n-74\n-18\n-27\n-33\n-94\n-99\n-111\n-86\n-40\n-98\n-29\n-130\n-3\n-128\n-49\n-135\n-40\n-4\n-68\n-70\n-97\n-77\n-164\n-73\n-161\n-106\n-136\n-110\n-130\n-78\n-103\n-16\n-36\n-165\n-144\n-15\n-75\n-21\n-116\n-105\n-157\n-36\n-79\n-3\n-122\n-122\n-138\n-24\n-56\n-90\n-10\n-53\n-2\n-86\n-2\n-29\n-108\n-15\n-47\n2\n-181\n-170\n-68\n-58\n-66\n-194\n-128\n-84\n-211\n-174\n-93\n-47\n-13\n-60\n-18\n-120\n-106\n-39\n-127\n-42\n-19\n-201\n-184\n-228\n-193\n-201\n-112\n-128\n-124\n-215\n-115\n-187\n-163\n-179\n-107\n-146\n-188\n-239\n-47\n-68\n-128\n-140\n-124\n-11\n-5\n-124\n-222\n-21\n-99\n-164\n-239\n-94\n-167\n-239\n-39\n-191\n-23\n-141\n-184\n-223\n-256\n-45\n-31\n-156\n-100\n-232\n-100\n-70\n-5\n-12\n-216\n-2\n-69\n-4\n-207\n-221\n-38\n-239\n-202\n-13\n-1\n-281\n-238\n-220\n-243\n-188\n-105\n-30\n-123\n-206\n-8\n-92\n-121\n-42\n-228\n-64\n-210\n-217\n-78\n-264\n-24\n-67\n-187\n-159\n-64\n-32\n-234\n-219\n-177\n-305\n-17\n-217\n-67\n-102\n-270\n-223\n-132\n-314\n-108\n-220\n-240\n-200\n-116\n-22\n-273\n-197\n-239\n-64\n-247\n2\n-237\n-135\n-93\n-282\n-145\n-73\n-296\n-1\n-129\n-12\n-85\n-331\n-329\n-13\n-68\n-52\n-312\n-219\n-182\n-322\n-116\n-192\n-203\n-85\n-167\n-173\n-245\n-149\n-98\n-202\n-62\n-352\n-152\n-171\n-142\n-97\n-78\n-309\n-350\n-346\n-15\n-368\n-69\n-48\n-73\n-77\n-261\n-208\n-253\n-357\n-96\n-96\n-280\n-235\n-127\n-173\n-79\n-378\n-56\n-393\n-351\n-287\n-120\n-362\n-164\n-8\n-234\n-369\n-347\n-152\n-4\n-39\n-186\n-220\n-136\n-166\n-247\n-61\n-303\n-84\n-160\n-64\n-359\n-57\n-187\n-379\n-28\n-121\n-276\n-230\n-294\n-359\n-420\n-373\n-220\n-71\n-42\n-207\n-281\n-293\n-107\n-91\n-173\n-358\n-51\n-97\n-317\n-240\n-85\n-411\n-310\n-319\n-94\n-90\n-395\n-439\n-275\n-221\n-120\n-424\n-392\n-356\n-250\n-460\n-350\n-98\n-265\n-446\n-423\n-141\n-14\n-321\n-125\n-118\n-294\n-237\n-114\n-242\n-106\n-20\n-208\n-225\n-367\n-187\n-406\n-401\n-456\n-111\n-348\n-268\n-34\n-262\n-358\n-170\n-346\n-336\n-268\n-423\n-168\n-335\n-391\n-456\n-106\n-322\n-84\n-89\n-171\n-442\n-217\n-2\n-309\n-507\n-306\n-415\n-345\n-234\n-453\n-94\n-307\n-378\n-48\n-516\n-307\n-443\n-249\n-23\n-404\n-373\n-59\n-264\n-164\n-105\n-137\n-77\n-442\n-143\n-464\n-493\n-465\n-131\n-400\n-325\n-56\n-212\n-522\n-436\n-535\n-444\n-217\n-389\n-360\n-372\n-514\n-114\n-340\n-411\n-70\n-285\n-158\n-92\n-345\n-442\n-305\n-353\n-229\n-548\n-100\n-239\n-355\n-15\n-564\n-435\n-342\n-97\n-181\n-324\n-151\n-137\n-297\n-35\n-124\n-551\n-383\n-98\n-280\n-259\n-236\n-243\n-395\n-158\n-576\n-512\n-276\n-284\n-274\n-548\n-173\n-480\n-288\n-197\n-399\n-244\n-337\n-545\n0\n-192\n-432\n-14\n-588\n-394\n-248\n-138\n-230\n-491\n-525\n-353\n-571\n-155\n-564\n-387\n-171\n-346\n-273\n-23\n-498\n-131\n-14\n-27\n-238\n-24\n-303\n-299\n-92\n-556\n-174\n-526\n-387\n-431\n-230\n-239\n-483\n-191\n-173\n-416\n-241\n-438\n-173\n-184\n-254\n-364\n-29\n-338\n-57\n-298\n-490\n-524\n-610\n-121\n-500\n-21\n-275\n-149\n-547\n-400\n-50\n-79\n-168\n-33\n-110\n-154\n-205\n-483\n-564\n-657\n-662\n-405\n-376\n-55\n-202\n-244\n-407\n-578\n-273\n-353\n-89\n-550\n-356\n-610\n-253\n-247\n-133\n-358\n-190\n-288\n-546\n-269\n-419\n-316\n-573\n-649\n-515\n-137\n-115\n-60\n-376\n-672\n-421\n-70\n-188\n-66\n-287\n-398\n-488\n-655\n2\n-559\n-569\n-282\n-626\n-97\n-595\n-438\n-82\n-140\n-175\n-132\n-550\n-145\n-164\n-724\n-53\n-352\n-225\n-685\n-272\n-254\n-441\n-527\n-648\n-305\n-145\n-221\n-242\n-201\n-499\n-586\n-387\n-570\n-307\n-2\n-650\n-176\n-587\n-275\n-182\n-555\n-235\n-609\n-68\n-418\n-305\n-479\n-503\n-25\n-174\n-324\n-490\n-131\n-674\n-699\n-731\n-586\n-348\n-472\n-290\n-623\n-60\n-131\n-421\n-243\n-324\n-518\n-660\n-188\n-36\n-202\n-586\n-531\n-711\n-93\n-568\n-508\n-35\n-318\n-264\n-138\n-773\n-600\n-65\n-387\n-556\n-9\n-457\n-580\n-663\n-422\n-230\n-477\n-164\n-63\n-205\n-708\n-493\n-616\n-174\n-281\n-726\n-162\n-115\n-582\n-464\n-447\n-80\n-468\n-368\n-576\n-596\n-459\n-624\n-145\n-437\n-768\n-454\n-207\n-441\n-710\n-669\n-235\n-97\n-642\n-456\n-18\n-155\n-206\n-838\n-344\n-143\n-354\n-133\n-411\n-52\n-836\n-130\n-658\n-812\n-561\n-71\n-705\n-752\n0\n-421\n-168\n-443\n-715\n-478\n-198\n-569\n-836\n-660\n-396\n-623\n-543\n-756\n-268\n-367\n-372\n-634\n-561\n-735\n-704\n-827\n-310\n-351\n-692\n-831\n-540\n-290\n-378\n-742\n-372\n-37\n-395\n-518\n-185\n-424\n-195\n-184\n-728\n-874\n-595\n-816\n-414\n-224\n-436\n-406\n-867\n-739\n-13\n-560\n-779\n-330\n-788\n-237\n-488\n-274\n-208\n-203\n-485\n-433\n-657\n-90\n-221\n-169\n-178\n-45\n-152\n-554\n-286\n-811\n-656\n-400\n-482\n-375\n-431\n-254\n-391\n-888\n-676\n-663\n-672\n-732\n-90\n-410\n-784\n-275\n-266\n-537\n-347\n-833\n-320\n-939\n-387\n-296\n-755\n-721\n-18\n-491\n-770\n-839\n-16\n-576\n-296\n-773\n-468\n-222\n-222\n-851\n-377\n-430\n-681\n-598\n-369\n-777\n-571\n-712\n-350\n-584\n-364\n-877\n-244\n-384\n-538\n-815\n-324\n-367\n-304\n-216\n-553\n-492\n-898\n-828\n-980\n-667\n-252\n-186\n-5\n-253\n-384\n-404\n-255\n-121\n-82\n-458\n-159\n-55\n-92\n-805\n-383\n-918\n-606\n-509\n-444\n-851\n-925\n-596\n-774\n-476\n-611\n-823\n-576\n-596\n-108\n-464\n-652\n-480\n-218\n-634\n-302\n-10\n-596\n-170\n-176\n-107\n-467\n-754\n-207\n-614\n-567\n-925\n-743\n-955\n-256\n-651\n-498\n-365\n-638\n-614\n-99\n-836\n-269\n-34\n-468\n-955\n-767\n-798\n-730\n-85\n-437");
            var result = solver.Execute();
            Assert.That(result.Part1Result, Is.EqualTo("358131"));
            Assert.That(result.Part2Result, Is.EqualTo("25558839"));
        }
    }
}
