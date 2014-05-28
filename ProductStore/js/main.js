$(function() {
/* ----- Main Menu ----- */	
	if($().superfish) {
		$("#navigation > ul").superfish({
			delay: 150, // delay on mouseout 
	        animation: { height:'show' }, // fade-in and slide-down animation 
	        speed: 'fast', // faster animation speed 
	        autoArrows: false, // disable generation of arrow mark-up 
	        dropShadows: false
		});
	}	
});


$(document).ready(function(){
  $('.bxslider').bxSlider();
});
$(document).ready(function(){
	new UISearch( document.getElementById( 'sb-search' ) );});