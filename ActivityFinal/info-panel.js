/* global AFRAME */
AFRAME.registerComponent('info-panel', {
  init: function () {
    var buttonEls = document.querySelectorAll('.menu-button');
    var fadeBackgroundEl = this.fadeBackgroundEl = document.querySelector('#fadeBackground');

    this.movieTitleEl = document.querySelector('#movieTitle');
    this.movieDescriptionEl = document.querySelector('#movieDescription');

    this.movieInfo = {
      karigurashiButton: {
        title: 'Mixed Reality (MR)',
        imgEl: document.querySelector('#karigurashiMovieImage'),
        description: 'MR is the combination of both virtual reality and augmented reality where both mediums coexist at the same time. It is used with devices like VR headsets such as Meta Quest 3s, Meta Quest Pros, and Apple Vision Pro.'
      },
      kazetachinuButton: {
        title: 'Augmented Reality (AR)',
        imgEl: document.querySelector('#kazetachinuMovieImage'),
        description: 'AR is a technology that overlays digital information, such as images, text, or 3D models, onto a real-world environment in real-time. This technology enhances the user perception of the physical world by integrating digital content over it. For example snapchat filters and bitmojis'
      },
      ponyoButton: {
        title: 'Virtual Reality (VR)',
        imgEl: document.querySelector('#ponyoMovieImage'),
        description: 'VR is an interactive computer-generated simulation of a three-dimensional image or environment that can be interfaced with using special electronic equipment, such as a helmet with a screen inside or wearables fitted with sensors like the Apple Vision Pro.'
      }
    };

    this.onMenuButtonClick = this.onMenuButtonClick.bind(this);
    this.onBackgroundClick = this.onBackgroundClick.bind(this);
    this.backgroundEl = document.querySelector('#background');
    for (var i = 0; i < buttonEls.length; ++i) {
      buttonEls[i].addEventListener('click', this.onMenuButtonClick);
    }
    this.backgroundEl.addEventListener('click', this.onBackgroundClick);
    this.el.object3D.renderOrder = 9999999;
    this.el.object3D.depthTest = false;
    fadeBackgroundEl.object3D.renderOrder = 0;
    fadeBackgroundEl.getObject3D('mesh').material.depthTest = false;
  },

  onMenuButtonClick: function (evt) {
    var movieInfo = this.movieInfo[evt.currentTarget.id];

    this.backgroundEl.object3D.scale.set(1, 1, 1);

    this.el.object3D.scale.set(1, 1, 1);
    if (AFRAME.utils.device.isMobile()) { this.el.object3D.scale.set(1.4, 1.4, 1.4); }
    this.el.object3D.visible = true;
    this.fadeBackgroundEl.object3D.visible = false;

    if (this.movieImageEl) { this.movieImageEl.object3D.visible = false; }
    this.movieImageEl = movieInfo.imgEl;
    this.movieImageEl.object3D.visible = true;

    this.movieTitleEl.setAttribute('text', 'value', movieInfo.title);
    this.movieDescriptionEl.setAttribute('text', 'value', movieInfo.description);
  },

  onBackgroundClick: function (evt) {
    this.backgroundEl.object3D.scale.set(0.001, 0.001, 0.001);
    this.el.object3D.scale.set(0.001, 0.001, 0.001);
    this.el.object3D.visible = false;
    this.fadeBackgroundEl.object3D.visible = false;
  }
});
