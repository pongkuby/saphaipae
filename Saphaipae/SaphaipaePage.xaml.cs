﻿using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Saphaipae
{
	public partial class SaphaipaePage : ContentPage
	{
		void SearchButton_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("สะพายเป้", "กำลังค้นหา..." + searchText.Text, "ยกเลิก");
		}

		public SaphaipaePage()
		{
			InitializeComponent();
			ObservableCollection<Review> demoList = new ObservableCollection<Review>();
			demoList.Add(new Review
			{
				Title = "หินสามวาฬ ภูสิงห์ หินยักษ์รูปวาฬสุดอันซีนที่บึงกาฬ",
				SubTitle = "หินยักษ์รูปร่างคล้ายวาฬติดหน้าผาสูงในจังหวัดบึงกาฬ ที่ไม่ว่าใครก็ไม่ควรพลาด",
				ImageUrl = "http://img.kapook.com/u/2016/suppaporn/mountain/phusing/phu04.jpg",
				Detail = "หินสามวาฬ หนึ่งในจุดสถานที่ท่องเที่ยวที่น่าสนใจของภูสิงห์ ตั้งอยู่ในเขตพื้นที่อนุรักษ์ในเขตป่าสงวนแห่งชาติป่าดงดิบกะลา ป่าภูสิงห์ และป่าดงสีชมพู ในพื้นที่ของภูสิงห์เอง เต็มไปด้วยกลุ่มของก้อนหินรูปทรงต่าง ๆ หน้าผา และถ้ำ กระจายอยู่ทั่วพื้นที่ เกิดเป็นความสวยงามที่ชวนให้สะกดสายตานักท่องเที่ยวทั่วไป รวมถึงหินสามวาฬ ที่มีลักษณะเป็นหินขนาดใหญ่ติดหน้าผาสูง แยกตัวเป็น 3 ก้อน มีอายุประมาณ 75 ล้านปี หนึ่งเดียวของโลก ความพิเศษของหินสามวาฬอยู่ตรงที่ เมื่อมองดูจากระยะไกล หินสามก้อนนี้จะดูคล้ายกับฝูงครอบครัววาฬ ที่ประกอบด้วยพ่อวาฬ แม่วาฬ และลูกวาฬ ซึ่งเรียกตามขนาดของหินแต่ละก้อน"
			});
			demoList.Add(new Review
			{
				Title = "น้ำตกนพพิบูลย์ แหล่งท่องเที่ยวใหม่ส่งตรงจากสังขละบุรี",
				SubTitle = "ที่เที่ยวน้องใหม่ เย็นฉ่ำใจ ในเมืองกาญจน์",
				ImageUrl = "http://img.kapook.com/u/2016/suppaporn/2016/waterfall/noppiboon/w02.jpg",
				Detail = "น้ำตกนพพิบูลย์\" หรือที่ชาวบ้านเรียกกันว่า \"น้ำตกหมวดเดช\" อยู่ในเขตพื้นที่ตำบลหนองลู อำเภอสังขละบุรี จังหวัดกาญจนบุรี ลักษณะที่สวยงามและโดดเด่นด้วยชั้นหินปูนขนาดเล็กไล่ระดับ โดยมีสายน้ำลดหลั่นกันลงมาเป็นแอ่งตื้น ๆ และไหลทอดยาวตกลงสู่หน้าผา ที่มีความสูงประมาณ 25 เมตร ส่งเสียงน้ำก้องดังไปทั่วบริเวณ แถมยังอยู่ในระดับที่ปลอดภัยและนักท่องเที่ยวสามารถลงเล่นน้ำได้ ปัจจุบัน(สิงหาคม 2559) บริเวณน้ำตกนพพิบูลย์ ยังไม่มีสิ่งอำนวยความสะดวกใด ๆ มีเพียงป้อมจุดสกัดตรวจค้น ไม่มีร้านค้า ร้านอาหาร หรือลานจอดรถ รถยนต์ต้องจอดริมถนน จากจุดจอดรถเดินไปเพียง 50 เมตร ก็จะถึงน้ำตกชั้นแรก ส่วนการเดินจากน้ำตกจากชั้นบนสู่ชั้นล่าง มีลักษณะเป็นทางดิน ผ่านป่าเบญจพรรณและป่าไผ่ บางช่วงจะมีบันไดไม้ที่ชาวบ้านช่วยกันทำไว้ให้ พื้นดินตามทางเดินอาจลื่นและชันในบางช่วง หากฝนตกควรใช้ความระมัดระวังมากเป็นพิเศษ และควรสวมใส่รองเท้าที่เหมาะสม"  
			});
			demoList.Add(new Review
			{
				Title = "หวาดเสียวกลางป่าใหญ่ กับ DoiTung Tree Top Walk สวนแม่ฟ้าหลวง",
				SubTitle = "สะพานบนเรือนยอดไม้สุดเสียว ที่เที่ยวเชียงรายแห่งใหม่ ที่จะมาท้าใจคนชอบความสูงให้ไปเดินขาสั่นบนฟ้ากลางป่าใหญ่ที่สูงจากพื้นดินกว่า 10-20 เมตร",
				ImageUrl = "http://img.kapook.com/u/2016/suppaporn/chiangrai/ttopwalk/doi02.jpg",
				Detail = "ชวนไปเที่ยวที่เที่ยวเชียงรายแห่งใหม่ กับเส้นทางศึกษาธรรมชาติบนเรือนยอดไม้ หรือ DoiTung Tree Top Walk ภายในสวนแม่ฟ้าหลวง พระตำหนักดอยตุง จังหวัดเชียงราย ที่สร้างขึ้นมาเหนือยอดไม้ใหญ่ภายในสวนอันเขียวขจี อากาศหนาวเย็น ได้สัมผัสกับธรรมชาติอย่างแท้จริง และยังท้าทายความกล้าของนักท่องเที่ยวที่ชอบความสูง นอกจากนี้ เส้นทางศึกษาธรรมชาติบนเรือนยอดไม้ หรือ Tree Top Walk สวนแม่ฟ้าหลวง เชียงราย เป็นเส้นทางศึกษาธรรมชาติบนเรือนยอดไม้ มีระยะทางทั้งหมดประมาณ 300 เมตร โดยแบ่งออกเป็น 6 ช่วง บนระดับความสูง 10-20 เมตร ลดหลั่นไปตามจังหวะของต้นไม้และความลาดชัน ซึ่งตลอดระยะทางจะมีต้นไม้น้อยใหญ่นานาพรรณให้ได้ชื่นชม และมีหลากหลายสถานีท้าวัดใจคนที่ชอบความเสียว"
			});
			demoList.Add(new Review
			{
				Title = "ชวนเที่ยวทุ่งปอเทืองหัวหิน งามสะดุดตา สวยสะกดใจ",
				SubTitle = "ทุ่งปอเทืองหัวหิน จังหวัดประจวบคีรีขันธ์ อีกหนึ่งสถานที่ท่องเที่ยวหัวหิน ที่ออกดอกสีเหลืองบานสะพรั่งเต็มท้องนากว่า 200 ไร่ ไม่ว่าใครต่างก็เดินทางไปเก็บภาพบรรยากาศความสวยงามด้วยกันทั้งนั้น",
				ImageUrl = "http://img.kapook.com/u/2016/suppaporn/huahin/flower/hh02.jpg",
				Detail = "ทุ่งปอเทืองหัวหิน ตั้งอยู่บริเวณบ้านหนองซอ ตำบลหินเหล็กไฟ อำเภอหัวหิน จังหวัดประจวบคีรีขันธ์ ซึ่งในขณะนี้กำลังออกดอกสีเหลืองบานสะพรั่งบนเนื้อที่กว่า 200 ไร่ ว่ากันว่าที่นี่เป็นทุ่งปอเทืองที่ใหญ่ที่สุดของอำเภอหัวหิน โดยทุ่งปอเทืองหัวหินแห่งนี้ได้เริ่มออกดอกบานสะพรั่งเมื่อช่วงต้นเดือนกรกฎาคม 2559 ซึ่งถ้ายังมีฝนตกอยู่อย่างต่อเนื่องก็จะเป็นการยืดอายุการบานให้กับต้นปอเทืองต่อไปอีกประมาณ 1-2 เดือน ก่อนที่จะมีการไถกลบ เพื่อทำปุ๋ยให้กับท้องนาต่อไป "
			});
			demoList.Add(new Review
			{
				Title = "สะพานบุญโขกู้โส่ ที่เที่ยวปายแห่งใหม่ สะพานไม้ไผ่ท่ามกลางท้องนา",
				SubTitle = "สะพานบุญโขกู้โส่ บ้านแพมบก ตำบลทุ่งยาว อำเภอปาย จังหวัดแม่ฮ่องสอน สะพานไม้ไผ่ยาวท่ามกลางทุ่งนาสีเขียวและภูเขาน้อยใหญ่ สัมผัสธรรมชาติอันสวยงาม พร้อมชมวิถีชีวิตสุดเรียบง่ายของชาวบ้าน",
				ImageUrl = "http://wm.thaibuffer.com/o/u/2016/suppaporn/2016/pai/soo01.jpg",
				Detail = "สะพานบุญโขกู้โส่ มีความยาวทั้งหมด 815 เมตร สูงจากพื้นดินประมาณ 1-2 เมตร สร้างขึ้นจากโครงปูนและเหล็ก ใช้ไม้ไผ่สานเป็นพื้นด้านบน กว้างประมาณ 1 เมตร สองฟากฝั่งทางเดินจะเป็นนาข้าวสุดกว้างใหญ่ และป่าเขาอันเขียวขจี บรรยากาศเงียบสงบ อากาศเย็นสบายสดชื่น เหมาะแก่การไปท่องเที่ยวพักผ่อน เป็นสะพานสร้างเชื่อมระหว่างหมู่บ้านแพมบกและวัดห้วยคายคีรี มีจุดประสงค์หลักคือเพื่อให้พระสงฆ์ข้ามมาบิณฑบาตในตอนเช้าได้สะดวกมากยิ่งขึ้น โดยที่ไม่ต้องเหยียบย่ำพืชผลทางการเกษตรของชาวบ้าน และยังเป็นสถานที่ท่องเที่ยวสุดชิล ท่ามกลางวิวสวย ๆ ของป่าเขาและทุ่งนาอีกด้วย "
			});
			demoList.Add(new Review
			{
				Title = "ล่องแพไม้ไผ่ ชมวิวธรรมชาติ ณ ธารมรกต จังหวัดพังงา",
				SubTitle = "ที่เที่ยวหน้าฝนแห่งใหม่ของพังงา ให้นักท่องเที่ยวได้ล่องแพไม้ไผ่ ชมความสวยงามของธรรมชาติสองข้างลำคลองแบบเต็ม ๆ",
				ImageUrl = "http://wm.thaibuffer.com/o/u/2016/suppaporn/south/pungngar/p01.jpg",
				Detail = "ธารมรกตแห่งนี้มีลักษณะเป็นคลองที่ทอดยาวตามธรรมชาติ ความพิเศษของธารมรกตแห่งนี้ อยู่ที่ความนิ่งและความใสของน้ำคล้ายสีเขียวมรกต จนมองลงไปเห็นหินใต้สระเลยทีเดียว นอกจากนี้พื้นที่โดยรอบสองข้างทางของลำคลอง ยังโอบล้อมด้วยธรรมชาติล้วน ๆ โดยการล่องแพของที่นี่ มีลักษณะเป็นแพไม้ไผ่ กินระยะทางยาวประมาณ 3 กิโลเมตร และใช้เวลาในการล่องประมาณ 1 ชั่วโมง (ทั้งนี้อาจมีช้าหรือเร็วกว่า 1 ชั่วโมงบ้าง ขึ้นอยู่กับระดับน้ำและจุดที่นักท่องเที่ยวลงล่องแพ)"
			});
			demoList.Add(new Review
			{
				Title = "พัทลุง จุดเช็กอินสัมผัสธรรมชาติแบบพาโนรามา",
				SubTitle = "จุดชมวิวแห่งใหม่นี้ นักท่องเที่ยวจะได้พบกับบรรยากาศสุดฟินและสัมผัสกับความงามของธรรมชาติที่น่าตื่นตาตื่นใจ ซึ่งกำลังเตรียมเปิดเป็นจุดชมวิวแลนด์มาร์กที่เที่ยวพัทลุงแห่งใหม่แบบชิล ๆ ใครไปพักรับรองติดใจ",
				ImageSource = "http://wm.thaibuffer.com/o/u/2016/suppaporn/south/tanod/p01.jpg",
				Detail = " จุดชมวิวบ้านควนโหมด ตั้งอยู่ที่ตำบลตะโหมด อำเภอตะโหมด จังหวัดพัทลุง จุดชมวิวบริเวณดังกล่าวมีลักษณะเป็นเนินควนสูงราว 50 เมตร และมีพื้นที่ตรงกลางโล่ง ไว้สำหรับเป็นพื้นที่ยืนชมวิวทิวทัศน์ได้โดยรอบ ทั้งทิศเหนือ ทิศตะวันออก ทิศตะวันตก ทิศใต้ ซึ่งแต่ละทิศล้วนแล้วแต่มีธรรมชาติที่น่าสนใจแตกต่างกัน จึงน่าจะถูกใจสำหรับนักท่องเที่ยวที่ชื่นชอบการถ่ายภาพ พร้อมชื่นชมบรรยากาศของท้องทุ่งนาและผืนป่า ในตอนเช้าคุณจะเห็นแสงพระอาทิตย์ที่สาดส่องทอแสงยามเช้า วันดีคืนดีคุณอาจจะได้เห็นสายหมอกบาง ๆ สลับกับสายหมอกหนาเข้าปกคลุม หรือแม้แต่ในช่วงยามเย็น ท้องฟ้าที่นี่ก็จะปลอดโปร่งดูโล่งสบายตา เผยให้เห็นก้อนเมฆที่สวยงามรูปลักษณ์ต่าง ๆ ชวนให้จินตนาการได้อย่างไม่มีที่สิ้นสุด"
			});
			reviewList.ItemsSource = demoList;
		}

		void OnTap(object sender, ItemTappedEventArgs e)
		{
			var review = (Review)e.Item;
			var detailPage = new DetailPage();
			detailPage.setDetail(review);
			Navigation.PushAsync(detailPage);
		}
	}
}

