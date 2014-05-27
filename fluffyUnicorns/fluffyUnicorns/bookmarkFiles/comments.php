<div id="ce">
    <h2>Comments</h2>

    <div id="ce_list"></div>

    <form id="ce_form" name="ce_form" method="POST" action=".">
        <label for="ce_name">
            Name: <input type="text" name="ce_name" id="ce_name" />
        </label>
        <br />
        <label for="ce_comment">
            Comment: <textarea name="ce_comment" id="ce_comment"></textarea>
        </label>
        <br />
        <input type="submit" value="Add Comment" />
    </form>
</div>
<?php 
$blogName = str_replace(".php", "", $_SERVER['PHP_SELF']);
$shareLink = 'http://brewhahablog.com'.$blogName;
?>
<div id="share_links">
<a href="http://www.facebook.com/sharer/sharer.php?u=<?php echo $shareLink ?>">Share on Facebook</a>
<a href="http://www.linkedin.com/shareArticle?mini=true&amp;url=<?php echo $shareLink ?>">Share On LinkedIn</a>
<a href="http://twitter.com/intent/tweet?text=Message&amp;url=<?php echo $shareLink ?>">Share On Twitter</a>
    </div>
