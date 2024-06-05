using Microsoft.AspNetCore.Mvc;

namespace USKT_Community.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.question_one = "How do I join the USKT Community?";
            ViewBag.question_two = "Can I ask questions on the USKT Community platform?";
            ViewBag.question_three = "How can I contribute to the community?";
            ViewBag.question_four = "How can I contact customer support if I need assistance?";
            ViewBag.question_five = "Are there any membership fees?";

            ViewData["answer_one"] = "To join the USKT Community, simply click on the \"Join Now\" button on our homepage and follow the instructions to create your account. It's quick, easy, and free!";
            ViewData["answer_two"] = "Yes, absolutely! Our platform encourages users to ask questions on a wide range of topics related to academics, student life, and more. Simply navigate to the \"Questions\" page and click on the \"Ask a Question\" button to get started.";
            ViewData["answer_three"] = "There are many ways to contribute! You can ask questions, provide answers, share your knowledge and expertise, participate in discussions, and engage with other members. Your contributions help enrich the community experience for everyone.";
            ViewData["answer_four"] = " If you have any questions, concerns, or need assistance, our customer support team is here to help! You can reach us through the contact form on our website, and we'll get back to you as soon as possible.";
            ViewData["answer_five"] = "No, membership in our community is completely free. We believe in providing access to knowledge and resources without any barriers.";

            TempData["info_one"] = "Connect with Peers to sahre your thoughts";
            TempData["info_two"] = "Engage in Thoughtful Discussions";
            TempData["info_three"] = "Be part of a Supportive Community";

            return View();
        }
    }
}
